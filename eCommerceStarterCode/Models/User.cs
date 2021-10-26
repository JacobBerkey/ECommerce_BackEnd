using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace eCommerceStarterCode.Models
{
    public partial class User : IdentityUser
    { 
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
