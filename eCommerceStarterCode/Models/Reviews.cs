using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Reviews 
    {
        public int ReviewId { get; set; }
        public string ReviewBody { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("Product")]
        public Product Product { get; set; }


    }
}
