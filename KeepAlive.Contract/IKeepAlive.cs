using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KeepAlive.Contract
{
    /// <summary>
    /// 心跳服务契约
    /// </summary>
    [ServiceContract]
    public interface IKeepAlive
    {
        /// <summary>
        /// 测试服务连通性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        string SayHi(string name);

        /// <summary>
        /// 新增JOB
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [OperationContract]
        void AddJob(string param);
    }
}
