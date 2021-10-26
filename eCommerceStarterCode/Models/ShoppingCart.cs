//using System.Collections.Generic;
//namespace eCommerceStarterCode.Models
//{
//    public class ShoppingCart
//    {
//        public int UserId { get; set; }
//        public int ProductId { get; set; }
//        public int Quantity { get; set; }
//        public virtual Product Product { get; set; }
//        public virtual User User { get; set; }
//    }
//}

using System.ComponentModel.DataAnnotations.Schema;
namespace eCommerceStarterCode.Models
{

   
    public class ShoppingCart
    {
        
        
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }


        
    }
}
