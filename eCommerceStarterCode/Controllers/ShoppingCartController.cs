using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;



namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        //POST<baseurl>/api/shoppingcart/
        [HttpPost("{productId}"), Authorize]
        public IActionResult Post(int productId, [FromBody] ShoppingCart value)
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound("User not Found");
            }

            var selectecObject = _context.ShoppingCarts.Where(sc => (sc.UserId == userId && sc.ProductId == productId)).SingleOrDefault();
            if (selectecObject != null)
            {
                selectecObject.Quantity = selectecObject.Quantity + value.Quantity;
                _context.ShoppingCarts.Update(selectecObject);
            }
            else
            {
                value.UserId = user.Id;
                _context.ShoppingCarts.Add(value);
            }
            _context.SaveChanges();
            return StatusCode(201, selectecObject);
        }

        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound("User not Found");
            }

            var allUserProducts = _context.ShoppingCarts
                                          .Include(sc => sc.Product)
                                          .Select(sc => new { sc.UserId, sc.ProductId, sc.Product.Name, sc.Quantity, sc.Product.Price, sc.Product.Description, sc.Product.Category,
                                                              ExtendedPrice = sc.Quantity * sc.Product.Price})
                                          .ToList();
             return Ok(allUserProducts);
        }



            
        [HttpDelete("{productId}")]
        public IActionResult Delete(int ProductId)
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound("User not Found");
            }

            var itemToDelete = _context.ShoppingCarts.Where(sc => sc.ProductId == ProductId).SingleOrDefault();
            
            if(itemToDelete != null)
            {
                _context.ShoppingCarts.Remove(itemToDelete);
                _context.SaveChanges();
                return StatusCode(202, "Item was deleted from Shopping Cart");
            }
            else
            {
                return NotFound("Item not Found");
            }
        }
    }
}
