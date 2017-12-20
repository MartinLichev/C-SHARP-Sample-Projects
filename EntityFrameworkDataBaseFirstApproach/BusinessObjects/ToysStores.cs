﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ToysStores
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public Nullable<long> Size { get; set; }
        public string StoreOwner { get; set; }
        public Nullable<long> ToysCount { get; set; }
    }
}
