namespace KeepAlive
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
            this.KeepAliveServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.KnockServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // KeepAliveServiceProcessInstaller
            // 
            this.KeepAliveServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.KeepAliveServiceProcessInstaller.Password = null;
            this.KeepAliveServiceProcessInstaller.Username = null;
            // 
            // KnockServiceInstaller
            // 
            this.KnockServiceInstaller.Description = "定时访问指定站点";
            this.KnockServiceInstaller.ServiceName = "KnockService";
            this.KnockServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.KeepAliveServiceProcessInstaller,
            this.KnockServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller KeepAliveServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller KnockServiceInstaller;
    }
}