namespace FirstMVCMaktab140.Services
{
    public class ReportJobService
    {
        private readonly ILogger<ReportJobService> _logger;

        public ReportJobService(ILogger<ReportJobService> logger)
        {
            _logger = logger;
        }

        public void SendWelcomeEmail(string userName)
        {
            _logger.LogInformation("Welcome email sent for {UserName} at {Time}", userName, DateTime.Now);
        }

        public void NightlyCleanup()
        {
            _logger.LogInformation("Nightly cleanup executed at {Time}", DateTime.Now);
        }
    }
}
