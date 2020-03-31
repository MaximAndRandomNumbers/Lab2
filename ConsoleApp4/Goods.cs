using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    [XmlInclude(typeof(Product))]
    [XmlInclude(typeof(Set))]
    [XmlInclude(typeof(Consignment))]
    [Serializable]
    public abstract class Goods
    {
        abstract public bool isExpired(DateTime currentDate);
        abstract public void showInfo();      
    }
}
