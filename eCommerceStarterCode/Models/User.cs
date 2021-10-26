using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace eCommerceStarterCode.Models
{
    public partial class User : IdentityUser
    {
        
<<<<<<< HEAD
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
       
=======
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
     

        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
>>>>>>> d6aeec3a55aaf79958145f658d9842d361a69fcd
    }
}
