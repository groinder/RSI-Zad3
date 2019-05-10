using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Zad3Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Kalkulator : IKalkulator
    {
        double suma = 0;

        public double Dodaj(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Otrzymano {0} i {1}. Wynik: {2}", n1, n2, result);
            return result;
        }

        public double Odejmij(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Otrzymano {0} i {1}. Wynik: {2}", n1, n2, result);
            return result;
        }

        public double Pomnoz(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Otrzymano {0} i {1}. Wynik: {2}", n1, n2, result);
            return result;
        }

        public double Sumuj(double n1)
        {
            suma += n1;
            return suma;
        }
    }
}
