using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    [XmlRootAttribute("Product", Namespace = "ConsoleApp4",
   IsNullable = false)]
    public class Product : Goods
    {
        String Name { get; }
        float Value { get; }
        DateTime ProductionDate { get; }
        uint ExpirationTimeInDays { get; }

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
    }
}
