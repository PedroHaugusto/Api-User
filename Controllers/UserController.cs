using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users()
        {
            return new List<User>{
                new User{ Id = 1, Name = "Pedro", BirthDate = new DateTime (2005, 7, 17) }
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users());
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            var users = Users();
            users.Add(user);
            return Ok(users);
        }
    }
}