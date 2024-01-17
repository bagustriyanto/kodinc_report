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
        private readonly IUnitOfWork unitOfWork;
        public PopulateFileService(IConfiguration configuration, AppLogger logger, IServiceScopeFactory serviceScopeFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.serviceScopeFactory = serviceScopeFactory;

            unitOfWork = serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IUnitOfWork>();
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
                            var fileExists = await unitOfWork.fileHistoryRepository.GetFileHistoryByName(fileInfo.Name, cancellationToken);
                            if (fileExists is null)
                            {
                                DateTime currentTimestamp = DateTime.Now;

                                FileHistoryModel fileHistoryModel = new FileHistoryModel()
                                {
                                    CreatedAt = currentTimestamp,
                                    FileName = fileInfo.Name,
                                    FileTimestamp = fileInfo.Name.Split("_")[1].ToLower().Replace(".xlsx", "")
                                };
                                Domains.FileHistoryModel map = fileHistoryModel.MapToDomain();
                                map.Id = Guid.NewGuid();

                                await unitOfWork.fileHistoryRepository.Create(map, cancellationToken);

                                HistoryModel historyModel = new HistoryModel()
                                {
                                    FileName = fileInfo.Name,
                                    FilePath = file,
                                    CreatedAt = currentTimestamp
                                };
                                var historyMap = historyModel.MapToDomain();
                                historyMap.Id = Guid.NewGuid();

                                await unitOfWork.historyRepository.Create(historyMap, cancellationToken);

                                await unitOfWork.Save();
                                logger.Info(nameof(PopulateFileService), "Populate file success", new { file = fileInfo.FullName });
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