namespace Serviz
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zeeServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.zeeServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // zeeServiceProcessInstaller
            // 
            this.zeeServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.zeeServiceProcessInstaller.Password = null;
            this.zeeServiceProcessInstaller.Username = null;
            // 
            // zeeServiceInstaller
            // 
            this.zeeServiceInstaller.ServiceName = "Serviz";
            this.zeeServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.zeeServiceProcessInstaller,
            this.zeeServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller zeeServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller zeeServiceInstaller;
    }
}