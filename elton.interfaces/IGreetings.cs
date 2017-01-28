using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace elton.host
{
    //[ServiceContract]
    [ServiceContract(Namespace="http://Elton/2014")]
    public interface IGreetings
    {
        [OperationContract()]
        string GetFriendlyGreeting(string name);

        [OperationContract()]
        string GetRudeGreeting(string name);
    }
}
