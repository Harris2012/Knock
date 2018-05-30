using KeepAlive;
using KeepAlive.Contract;
using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace KeepAlive
{
    public partial class KnockService : ServiceBase, IKeepAlive
    {
        public KnockService()
        {
            InitializeComponent();
        }

        private ILog logger;

        ServiceHost host = null;

        protected override void OnStart(string[] args)
        {
            logger = LogManager.GetLogger(this.GetType());

            try
            {
                KeepAliveHeart.OnStart();

                host = new ServiceHost(this.GetType());
                host.Open();

                logger.Info("KeepAlive is started.");
            }
            catch (Exception ex)
            {
                logger.Fatal(nameof(OnStart), ex);
            }
        }

        protected override void OnStop()
        {
            try
            {
                host.Close();

                KeepAliveHeart.Shutdown();
            }
            catch (Exception ex)
            {
                logger.Fatal(nameof(OnStart), ex);
            }

            logger.Info("KeepAlive is stopped.");
        }

        protected override void OnPause()
        {
            KeepAliveHeart.PauseAll();
        }

        protected override void OnContinue()
        {
            KeepAliveHeart.ResumeAll();
        }

        #region IKeepAlive Members
        public string SayHi(string name)
        {
            return $"Hi, {name}";
        }

        public void AddJob(string param)
        {
            KeepAliveHeart.AddJob(param);
        }
        #endregion
    }
}
