﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionWebStoreApp.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public double UnitPrice { get; set; }
    }
}
