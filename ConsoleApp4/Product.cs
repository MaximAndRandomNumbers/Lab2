using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Product : Goods
    {
        public String Name { get; }
        public float Value { get; }
        public DateTime ProductionDate { get; }
        public uint ExpirationTimeInDays { get; }

        public Product(String name, float value, DateTime productionDate, uint expirationTimeInDays)
        {
            Name = name;
            Value = value;
            ProductionDate = productionDate;
            ExpirationTimeInDays = expirationTimeInDays;
        }

        public override bool isExpired(DateTime currentDate)
        {
            return ProductionDate.AddDays(ExpirationTimeInDays) < currentDate ? true : false;
        }

        public override void showInfo()
        {
            Console.WriteLine("Product:\n" +
                "\tName: " + Name +
                "\n\tValue: " + Value +
                "\n\tDate of production: " + ProductionDate.ToShortDateString() +
                "\n\tExpiration time in days: " + ExpirationTimeInDays);
        }
    }
}
