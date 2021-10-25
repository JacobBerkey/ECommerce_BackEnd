﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace eCommerceStarterCode.Models
{
    public partial class User : IdentityUser
    {
        
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
