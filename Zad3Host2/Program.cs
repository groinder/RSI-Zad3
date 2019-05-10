using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Zad3Contract;

namespace Zad3Host2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost mojHost = new ServiceHost(typeof(Kalkulator));

            try
            {
                ServiceEndpoint endpoint1 = mojHost.Description.Endpoints.Find(typeof(IKalkulator));
                ServiceEndpoint endpoint2 = mojHost.Description.Endpoints.Find(new Uri("http://localhost:10002/endpoint2"));
                ServiceEndpoint endpoint3 = mojHost.Description.Endpoints.Find(new Uri("http://localhost:20002/endpoint3"));

                Uri address4 = new Uri("net.tcp://localhost:30000/mojSerwisTCP");
                ServiceEndpoint endpoint4 = mojHost.AddServiceEndpoint(typeof(IKalkulator), new NetTcpBinding(), address4);

                Console.WriteLine("\n---> Endpointy:");
                Console.WriteLine("\nService endpoint {0}:", endpoint1.Name);
                Console.WriteLine("Binding: {0}", endpoint1.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint1.ListenUri.ToString());

                Console.WriteLine("\nService endpoint {0}:", endpoint2.Name);
                Console.WriteLine("Binding: {0}", endpoint2.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint2.ListenUri.ToString());

                Console.WriteLine("\nService endpoint {0}:", endpoint3.Name);
                Console.WriteLine("Binding: {0}", endpoint3.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint3.ListenUri.ToString());

                Console.WriteLine("\nService endpoint {0}:", endpoint4.Name);
                Console.WriteLine("Binding: {0}", endpoint4.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint4.ListenUri.ToString());

                mojHost.Open();
                Console.WriteLine("\n--> Serwis 1 jest uruchomiony.");

                ContractDescription cd = ContractDescription.GetContract(typeof(IKalkulator));
                Console.WriteLine("Informacje o kontrakcie: ");
                Type contractType = cd.ContractType;
                Console.WriteLine("\tContract type: {0}", contractType.ToString());
                string name = cd.Name;
                Console.WriteLine("\tName: {0}", name);
                OperationDescriptionCollection odc = cd.Operations;
                Console.WriteLine("\tOperacje:");
                foreach (OperationDescription od in odc)
                {
                    Console.WriteLine("\t\t" + od.Name);
                }

                Console.WriteLine("\n--> Nacisnij <ENTER> aby zakonczyc.");
                Console.WriteLine();
                Console.ReadLine();
                mojHost.Close();
            } catch (CommunicationException ce)
            {
                Console.WriteLine("Wystapil Wyjatek: {0}", ce.Message);
                mojHost.Abort();
            }
           
        }
    }
}
