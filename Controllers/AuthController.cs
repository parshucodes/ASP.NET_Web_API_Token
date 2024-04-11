using jwt11april.Interfaces;
using jwt11april.Model_Request;
using jwt11april.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jwt11april.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        // POST api/<AuthController>
        [HttpPost]
        public string Login([FromBody] LoginRequest loginModel)
        {
            var result = _authService.login(loginModel);
            return result;
        }

        // PUT api/<AuthController>/5
        [HttpPost("addUser")]
        public User AddUser([FromBody] User value)
        {
            var user = _authService.AddUser(value);
            return user;
        }

       
    }
}
