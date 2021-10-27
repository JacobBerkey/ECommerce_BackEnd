//using eCommerceStarterCode.Data;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


//namespace eCommerceStarterCode.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        private ApplicationDbContext _context;

//        public UserController(ApplicationDbContext context)
//        {
//            _context = context;
//        }
//        // GET api/user
//        [HttpGet]
//        public IActionResult Get(string id)
//        {
//            var user = _context.Users.Where(u => u.Id == id).Select(u => u.Id).SingleOrDefault;
//            return Ok(user);
//        }

        
//        }

//    }
//}
