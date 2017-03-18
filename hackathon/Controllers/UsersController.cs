using System.Collections.Generic;
using hackathon.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _userRepository;

        public UsersController(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}