﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory
    {
        public string Id {get; set;}
        public string Category { get; set;}

        //Constructor to generate ID when model is created
        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
