using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Zad3Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKalkulator" in both code and config file together.
    [ServiceContract]
    public interface IKalkulator
    {
        [OperationContract]
        double Dodaj(double n1, double n2);
        [OperationContract]
        double Odejmij(double n1, double n2);
        [OperationContract]
        double Pomnoz(double n1, double n2);
        [OperationContract]
        double Sumuj(double n1);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Zad3Contract.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
