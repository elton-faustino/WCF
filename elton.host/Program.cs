using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace elton.host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sv = new ServiceHost(typeof(Greeting));
                //,new Uri("net.tcp://localhost:8002"));

            sv.Open();
            Console.WriteLine(sv.BaseAddresses);
            Console.WriteLine("Serviço está rodando");
            Console.ReadLine();
        }
    }
}
