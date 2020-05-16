using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ObjectWCF;

namespace PostHostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Launching Posts Server...");
            var host = new ServiceHost(typeof(CommentService), new Uri("http://localhost:8001/Comment"));
            host.Open();
            Console.WriteLine("Awaiting connections...");
            Console.WriteLine("Press enter to exit!");
            Console.ReadKey();
            host.Close();
        }
    }
}