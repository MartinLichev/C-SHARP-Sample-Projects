using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [Serializable()]
    //[XmlRoot("Car")]
    public class Car
    {
        [XmlElement ("brand")]
        private string brand;
        [XmlElement ("model")]  
        private string model;
        [XmlElement ("yearofmanufacturing")]
        private int yearofmanufacturing;

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Yearofmanufacturing
        {
            get
            {
                return yearofmanufacturing;
            }

            set
            {
                yearofmanufacturing = value;
            }
        }
    }
}
 