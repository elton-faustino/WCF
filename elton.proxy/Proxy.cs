using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using elton.host;


namespace elton.proxy
{
    public class Proxy : ClientBase<IGreetings>, IGreetings
    {
        public string GetFriendlyGreeting(string name)
        {
            return Channel.GetFriendlyGreeting(name);
        }

        public string GetRudeGreeting(string name)
        {
            return Channel.GetRudeGreeting(name);
        }
    }

}
