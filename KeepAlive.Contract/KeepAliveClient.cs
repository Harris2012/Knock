using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace KeepAlive.Contract
{
    [DebuggerStepThrough]
    public class KeepAliveClient : ClientBase<IKeepAlive>, IKeepAlive
    {
        public KeepAliveClient() : base("keepalive")
        {
        }

        #region IKeepAlive Members
        public string SayHi(string name)
        {
            return this.Channel.SayHi(name);
        }

        public void AddJob(string param)
        {
            this.Channel.AddJob(param);
        }
        #endregion
    }
}
