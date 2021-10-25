﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace eCommerceStarterCode.Models
{
    public partial class Product
    {
       
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public string Category { get; set; }

        public ICollection<ShoppingCart>ShoppingCarts { get; set; }

    }

}




