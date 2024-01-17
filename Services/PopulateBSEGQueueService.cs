using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ReportService.Helpers;
using ReportService.Repositories.Interfaces;

namespace ReportService.Services
{
    public sealed class PopulateBSEGQueueService : IHostedService
    {
        private readonly AppLogger logger;
        private readonly IServiceScopeFactory serviceScopeFactory;
        private readonly IUnitOfWork unitOfWork;

        public PopulateBSEGQueueService(AppLogger logger, IServiceScopeFactory serviceScopeFactory)
        {
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
                    var history = await unitOfWork.historyRepository.GetLastHistory(AppConstant.INITIALIZE, cancellationToken);
                    if (history is not null)
                    {
                        // get rows from file and then insert to the db
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