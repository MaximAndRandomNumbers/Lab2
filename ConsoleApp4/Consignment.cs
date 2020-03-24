using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    class Consignment : Goods
    {
        Product Product { get; }
        uint Amount { get; }

        public Consignment(Product product, uint amount)
        {
            this.Product = product;
            this.Amount = amount;
        }

        public override bool isExpired(DateTime currentDate)
        {
            Trace.WriteLine("Method isExpired() in class Consignment is called");
            return Product.isExpired(currentDate);
        }

        public override void showInfo()
        {
            Trace.WriteLine("Method showInfo() in class Consignment is called");
            Console.WriteLine("Consignment of " + Amount + " products. Product description:");
            Product.showInfo();
        }
    }
}
