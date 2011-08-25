using System.ComponentModel;
using System.Configuration.Install;


namespace Serviz
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            //zeeServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.User;
            //zeeServiceProcessInstaller.Username = "Adron";
            //zeeServiceProcessInstaller.Password = "somePassword";

        }
    }
}
