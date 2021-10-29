using Microsoft.AspNetCore.Mvc;
using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using eCommerceStarterCode.Models;

namespace eCommerceStarterCode.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{ProductId:int}")]
        public IActionResult Get(int productId)
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound("User not Found");
            }

            var productReview = _context.Reviews.Where(re => re.ProductId == productId);
         
            return Ok(productReview);
        }


        [HttpPost("{productId}"), Authorize]
        public IActionResult Post(int productId, [FromBody] Review value)
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound("User not Found");
            }
            if(value != null)
            {
                value.ProductId = productId;
                _context.Reviews.Add(value);
                _context.SaveChanges();
                return Ok(value);
            }
            else
            {
                return StatusCode(400, "value null");
            }
          
        }
    }
}
