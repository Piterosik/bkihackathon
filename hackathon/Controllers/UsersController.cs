using System.Collections.Generic;
using hackathon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _userRepository;

        const string SessionKeyUsername = "_Username";
        const string SessionKeyId = "_ID";
        const string SessionKeyCloths = "_Cloths";

        public UsersController(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.Get();
        }

        [HttpPost("{login}")]
        public IActionResult Login([FromBody] User user)
        {
            if (_userRepository.Login(user.Username, user.Seed)) {
                HttpContext.Session.SetString(SessionKeyUsername, user.Username);
                HttpContext.Session.SetInt32(SessionKeyId, user.Id);
                HttpContext.Session.Set<IEnumerable<Cloth>>(SessionKeyCloths, GetCloths(user.Id));
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("{register}")]
        public IActionResult Register([FromBody] User user)
        {
            if (_userRepository.Register(user.Username, user.Seed)) {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{items}")]
        public IEnumerable<Cloth> GetCloths(int userid)
        {
            return _userRepository.GetCloths(userid);
        }
    }
}