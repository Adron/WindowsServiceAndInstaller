using System.ServiceProcess;

namespace Serviz
{
    public partial class Serviz : ServiceBase
    {
        public Serviz()
        {
            InitializeComponent();
            const string sourceName = "ZeeSource";
            const string logName = "ZeeLog";

            if (!System.Diagnostics.EventLog.SourceExists(sourceName))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    sourceName, logName);
            }
            theOneTheOnlyEventLog.Source = sourceName;
            theOneTheOnlyEventLog.Log = logName;
        }

        protected override void OnStart(string[] args)
        {
            theOneTheOnlyEventLog.WriteEntry("Zee Logging Has Started.");
        }

        protected override void OnStop()
        {
            theOneTheOnlyEventLog.WriteEntry("Zee Logging Has Ended.");
        }
    }
}
