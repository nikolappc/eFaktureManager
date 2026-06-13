using eFaktureModel.Services.Sync;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace eFaktureSync.Services
{
    public class SyncBackgroundService : BackgroundService
    {
        private readonly IEnumerable<ISyncService> _syncServices;
        private readonly ILogger<SyncBackgroundService> _logger;
        private readonly IConfiguration _configuration;
        private TimeSpan _interval;
        private TimeSpan _startDelay;

        public SyncBackgroundService(IEnumerable<ISyncService> syncServices, ILogger<SyncBackgroundService> logger, IConfiguration configuration)
        {
            _syncServices = syncServices;
            _logger = logger;
            _configuration = configuration;

            var minutes = _configuration.GetValue("SyncSettings:IntervalMinutes", 60);
            var startDelaySeconds = _configuration.GetValue("SyncSettings:StartDelaySeconds", 10);
            _interval = TimeSpan.FromMinutes(minutes);
            _startDelay = TimeSpan.FromSeconds(startDelaySeconds);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("[START] Sync service");

            await Task.Delay(_startDelay, stoppingToken);

            _logger.LogInformation("[START] Sync service");

            while (!stoppingToken.IsCancellationRequested)
            {
                foreach (var service in _syncServices)
                {
                    try
                    {
                        await service.SyncAsync();
                        _logger.LogInformation($"[DONE] Syncing using {service.GetType().Name} service.");
                    }
                    catch (Exception? ex)
                    {
                        _logger.LogError(ex, $"[ERROR] Syncing with {service.GetType().Name} service.");

                        while (ex != null)
                        {
                            _logger.LogError(ex, ex.Message);
                            _logger.LogError(ex, ex.StackTrace);
                            ex = ex?.InnerException;
                        }



                    }
                }

                await Task.Delay(_interval, stoppingToken);
            }

            _logger.LogInformation("[FINISH] All sync services finished");
        }
    }
}