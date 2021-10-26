using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/product
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var allProducts = _context.Products;
            return Ok(allProducts);  ;
        }

        [HttpGet("{ProductId:int}")]
        public IActionResult Get(int ProductId)
        {
            var product = _context.Products.Where(p => p.ProductId == ProductId).SingleOrDefault(); 
            return Ok(product); 
        }

        [HttpDelete("{ProductId:int}")]
        public IActionResult Delete(int productId)
        {
            var product = _context.Products.Where(p => p.ProductId == productId).SingleOrDefault();

            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return StatusCode(202, "Item Deleted");
            }
            else
            {
                return StatusCode(404, "Not Found");
            }
        }

    }
}