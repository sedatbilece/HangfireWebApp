using Hangfire;
using System.Diagnostics;

namespace HangfireWebApp.BackgroundJobs
{
    public class RecurringJob
    {

        public static void ReportingJob()
        {
            Hangfire.RecurringJob.AddOrUpdate("reportjob1", () => EmailReport(), Cron.Minutely);
        }

        public static void EmailReport()
        {
            Debug.WriteLine("Rapor gönderildi.");
        }
    }
}
