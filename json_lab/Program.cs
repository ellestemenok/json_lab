using System;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace json_lab
{        
    

    internal class Program
    {

        [DataContract]
        class Company
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string INN { get; set; }
            [DataMember]
            public string Adress { get; set; }
        }

        static void Main(string[] args)
        {
            Company company = new Company();
            company.INN = "1";
            company.Name = "Romashka";
            company.Adress = "Barnaul";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(company);
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
