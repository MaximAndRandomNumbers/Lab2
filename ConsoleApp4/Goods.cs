using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    [XmlRootAttribute("Goods", Namespace = "ConsoleApp4",
IsNullable = false)]
    public abstract class Goods
    {
        abstract public bool isExpired(DateTime currentDate);
        abstract public void showInfo();      
    }
}
