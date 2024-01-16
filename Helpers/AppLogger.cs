using NLog;

namespace ReportService.Helpers
{
    public class AppLogger
    {
        private readonly Logger logger;
        public AppLogger()
        {
            this.logger = NLog.LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
        }
        public void Debug(string methodName, string message, object stackTrace = null)
        {
            string logMessage = $"[{methodName}] {message}";
            if (stackTrace != null) logMessage = $"{logMessage} => {stackTrace}";

            this.logger.Debug(logMessage);
        }

        public void Info(string methodName, string message, object stackTrace = null)
        {
            string logMessage = $"[{methodName}] {message}";
            if (stackTrace != null) logMessage = $"{logMessage} => {stackTrace}";

            this.logger.Info(logMessage);
        }

        public void Error(string methodName, string message, object stackTrace = null)
        {
            string logMessage = $"[{methodName}] {message}";
            if (stackTrace != null) logMessage = $"{logMessage} => {stackTrace}";

            this.logger.Error(logMessage);
        }
    }
}