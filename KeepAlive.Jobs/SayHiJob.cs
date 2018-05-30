using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepAlive.Jobs
{
    public class SayHiJob : IJob
    {
        private ILog logger = LogManager.GetLogger(typeof(SayHiJob).FullName);

        public async Task Execute(IJobExecutionContext context)
        {
            var value = context.JobDetail.JobDataMap.Get("name");

            logger.Info(value);

            await Task.Delay(1);
        }
    }
}
