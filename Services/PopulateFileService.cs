using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using NLog;
using ReportService.Helpers;
using ReportService.Models;
using ReportService.Repositories.Interfaces;

namespace ReportService.Services
{
    public class PopulateFileService : IHostedService
    {
        private readonly IConfiguration configuration;
        private readonly AppLogger logger;
        private readonly IServiceScopeFactory serviceScopeFactory;
        private readonly IFileHistoryRepository fileHistoryRepository;
        public PopulateFileService(IConfiguration configuration, AppLogger logger, IServiceScopeFactory serviceScopeFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.serviceScopeFactory = serviceScopeFactory;

            fileHistoryRepository = serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IFileHistoryRepository>();
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Task.Run(async () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        string[] files = Directory.GetFiles(configuration["SourceFolderFile"]);
                        foreach (var file in files)
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            var fileExists = await fileHistoryRepository.GetFileHistoryByName(fileInfo.Name);
                            if (fileExists is null)
                            {
                                FileHistoryModel fileHistoryModel = new FileHistoryModel()
                                {
                                    CreatedAt = DateTime.Now,
                                    FileName = fileInfo.Name,
                                    FileTimestamp = fileInfo.Name.Split("_")[1].ToLower().Replace(".xlsx", "")
                                };
                                Domains.FileHistoryModel map = fileHistoryModel.MapToDomain();
                                map.Id = Guid.NewGuid();

                                await fileHistoryRepository.Create(map);
                                await fileHistoryRepository.SaveAsync();
                                logger.Info(nameof(PopulateFileService), file, new { lastWritte = fileInfo.LastWriteTime, createdat = fileInfo.CreationTime });
                            }
                        }
                        await Task.Delay(1000);
                    }
                    catch (Exception ex)
                    {
                        logger.Error(nameof(PopulateFileService), ex.Message, ex);
                    }
                }
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}