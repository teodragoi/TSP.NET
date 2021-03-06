﻿using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCFService;

namespace PhotoHostWCF
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Launch Photo Server...");
            var host = new ServiceHost(typeof(PhotoService), new Uri("http://localhost:8000/Photos"));

            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine("A (Address): {0} \nB (Binding): {1} \nC (Contract): {2}", se.Address, se.Binding, se.Contract);
            }
            host.Open();
            Console.WriteLine("Awaiting connections...");
            Console.WriteLine("Press Enter to shut down server.");
            Console.ReadKey();
            host.Close();
        }
    }
}
