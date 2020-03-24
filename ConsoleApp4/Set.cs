using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    class Set : Goods
    {
        Product[] Products { get; }

        public Set(Product[] products)
        {
            Array.Copy(products, this.Products, products.Length);
        }

        public override bool isExpired(DateTime currentDate)
        {
            Trace.WriteLine("Method isExpired() in class Set is called");
            foreach (Product prod in Products)
            {
                if (prod.isExpired(currentDate)) return true;
            }
            return false;
        }

        public override void showInfo()
        {
            Trace.WriteLine("Method showInfo() in class Set is called");
            Console.WriteLine("The set of products.\nProducts description\n////////");
            foreach(Product prod in Products)
            {
                prod.showInfo();
            }
            Console.WriteLine("////The end of the Set////");
        }
    }
}
