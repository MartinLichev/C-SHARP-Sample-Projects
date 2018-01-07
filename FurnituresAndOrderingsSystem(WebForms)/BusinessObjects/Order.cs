using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;


namespace BusinessObjects
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Width { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}
