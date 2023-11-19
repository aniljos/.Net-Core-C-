using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO
{
    public class Product
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlElement("ProductName")]
        public string Name { get; set; }
        public double Price { get; set; }

        
    }
}
