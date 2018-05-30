using KeepAlive.Jobs;
using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepAlive
{
    public static class KeepAliveHeart
    {
        private static ILog logger;
        private static IScheduler scheduler;

        public static void OnStart()
        {
            logger = LogManager.GetLogger(typeof(KeepAliveHeart));
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            var schedulertask = schedulerFactory.GetScheduler();
            Task.WaitAll(schedulertask);
            scheduler = schedulertask.Result;

            scheduler.Start();
        }

        public static void AddJob(string param)
        {
            IJobDetail job = JobBuilder.Create<SayHiJob>().WithIdentity(Guid.NewGuid().ToString("N")).Build();
            job.JobDataMap.Add("name", param);

            ITrigger trigger = TriggerBuilder.Create().WithIdentity(Guid.NewGuid().ToString("N")).StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();

            scheduler.ScheduleJob(job, trigger);
        }

        public static void Shutdown()
        {
            scheduler.Shutdown();

            logger.Info("Quartz is stopped.");
        }

        public static void PauseAll()
        {
            scheduler.PauseAll();

            logger.Info("Quartz is paused.");
        }

        public static void ResumeAll()
        {
            scheduler.ResumeAll();

            logger.Info("Quartz is resumed.");
        }
    }
}
