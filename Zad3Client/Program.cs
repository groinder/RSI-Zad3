using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad3Client.ServiceReference1;

namespace Zad3Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //KalkulatorClient mojKlient = new KalkulatorClient();

            KalkulatorClient klient1 = new KalkulatorClient("WSHttpBinding_IKalkulator");
            KalkulatorClient klient2 = new KalkulatorClient("WSHttpBinding_IKalkulator");
            KalkulatorClient klient3 = new KalkulatorClient("WSHttpBinding_IKalkulator");
            KalkulatorClient klient4 = new KalkulatorClient("NetTcpBinding_IKalkulator");

            double value1 = 3;
            double value2 = 2.5;

            double result = klient1.Dodaj(value1, value2);
            Console.WriteLine(result);

            result = klient1.Odejmij(value1, value2);
            Console.WriteLine(result);

            result = klient1.Pomnoz(value1, value2);
            Console.WriteLine(result);

            result = klient1.Sumuj(15);
            Console.WriteLine("Klient 1 suma: " + result);
            result = klient1.Sumuj(2);
            Console.WriteLine("Klient 1 suma: " + result);

            result = klient2.Sumuj(4);
            Console.WriteLine("Klient 2 suma: " + result);
            result = klient2.Sumuj(2);
            Console.WriteLine("Klient 2 suma: " + result);

            result = klient3.Sumuj(5);
            Console.WriteLine("Klient 3 suma: " + result);
            result = klient3.Sumuj(4);
            Console.WriteLine("Klient 3 suma: " + result);

            result = klient4.Sumuj(155);
            Console.WriteLine("Klient 4 suma: " + result);
            result = klient4.Sumuj(12);
            Console.WriteLine("Klient 4 suma: " + result);

            klient1.Close();
        }
    }
}
