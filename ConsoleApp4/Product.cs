using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    [Serializable]
    public class Product : Goods, ISerializable
    {         
        public String Name { get; set; }
        public float Value { get; set; }
        public DateTime ProductionDate { get; set; }
        public uint ExpirationTimeInDays { get; set; }

        public Product() { }
        public Product(String name, float value, DateTime productionDate, uint expirationTimeInDays)
        {
            Name = name;
            Value = value;
            ProductionDate = productionDate;
            ExpirationTimeInDays = expirationTimeInDays;
        }

        public override bool isExpired(DateTime currentDate)
        {
            Trace.WriteLine("Method isExpired() in class Product is called");
            return ProductionDate.AddDays(ExpirationTimeInDays) < currentDate ? true : false;
        }

        public override void showInfo()
        {
            Trace.WriteLine("Method showInfo() in class Product is called");
            Console.WriteLine("Product:\n" +
                "\tName: " + Name +
                "\n\tValue: " + Value +
                "\n\tDate of production: " + ProductionDate.ToShortDateString() +
                "\n\tExpiration time in days: " + ExpirationTimeInDays);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Value", Value);
            info.AddValue("ProductionDate", ProductionDate);
            info.AddValue("ExpirationTimeInDays", ExpirationTimeInDays);

        }
    }
}
