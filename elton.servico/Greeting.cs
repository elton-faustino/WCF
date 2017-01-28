using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using elton.host;
using elton.negocio;

namespace elton.host
{
    public class Greeting : IGreetings
    {

        public string GetFriendlyGreeting(string name)
        {
            var a = new GreetingBS();

            return a.GetFriendlyGreeting(name);
        }

        public string GetRudeGreeting(string name)
        {
            return string.Format("Ahhhh! seu nome é {0}", name);
        }
    }
}
