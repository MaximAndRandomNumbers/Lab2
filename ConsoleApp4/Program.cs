using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Goods[]));
            TextWriter writer = new StreamWriter("xmlInfo.xml");

            string[] data = File.ReadAllLines("input.txt");

            int n = Int32.Parse(data[0]);
            Goods[] goods = new Goods[n];

            //Fill array
            fillArray(goods, data);
            

            //Show info 
            showInfo(goods);

            //FindExpired
            findExpired(goods, DateTime.Now);
            foreach(Goods good in goods)
            {
                //serializer.Serialize(writer, good);
            }
            serializer.Serialize(writer, goods);
            writer.Close();

            Console.ReadKey();
        }

        static void fillArray(Goods[] goods, string[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                string[] info = data[i].Split(' ');
                string[] date = info[2].Split('.');
                int day = Int32.Parse(date[0]);
                int month = Int32.Parse(date[1]);
                int year = Int32.Parse(date[2]);
                goods[i-1] = new Product(info[0], float.Parse(info[1]), new DateTime(year, month, day), UInt32.Parse(info[3]));
            }
        }

        static void showInfo(Goods[] goods)
        {
            Console.WriteLine("////////////////List of goods////////////////");
            foreach (Goods good in goods)
            {
                good.showInfo();
            }
            Console.WriteLine("/////////////The end of the list/////////////");
        }

        static void findExpired(Goods[] goods, DateTime currentDate)
        {
            foreach(Product good in goods)
            {
                if (good.isExpired(currentDate))
                {
                    Console.WriteLine("This product is expired!");
                    good.showInfo();
                }
            }
        }
    }
}
