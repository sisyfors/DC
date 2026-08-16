using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ChatContracts
{
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        string TestConnection();
    }
}
