using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Consignment : Goods
    {
        Product product;
        uint amount;

        public Consignment(Product product, uint amount)
        {
            this.product = product;
            this.amount = amount;
        }

        public override bool isExpired(DateTime currentDate)
        {
            return product.isExpired(currentDate);
        }

        public override void showInfo()
        {
            Console.WriteLine("Consignment of " + amount + " products. Product description:");
            product.showInfo();
        }
    }
}
