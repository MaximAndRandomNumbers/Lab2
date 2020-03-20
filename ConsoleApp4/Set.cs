using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Set : Goods
    {
        Product[] products;

        public Set(Product[] products)
        {
            Array.Copy(products, this.products, products.Length);
        }

        public override bool isExpired(DateTime currentDate)
        {
           foreach(Product prod in products)
            {
                if (prod.isExpired(currentDate)) return true;
            }
            return false;
        }

        public override void showInfo()
        {
            Console.WriteLine("The set of products.\nProducts description\n////////");
            foreach(Product prod in products)
            {
                prod.showInfo();
            }
            Console.WriteLine("////The end of the Set////");
        }
    }
}
