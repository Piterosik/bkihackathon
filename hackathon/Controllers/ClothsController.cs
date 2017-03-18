using System.Collections.Generic;
using hackathon.Models;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    public class ClothsController : Controller
    {
        private readonly IClothsRepository _clothsRepository;

        public ClothsController(IClothsRepository clothsRepository)
        {
            _clothsRepository = clothsRepository;
        }

        [HttpGet]
        public IEnumerable<Cloth> Get()
        {
            return _clothsRepository.Get();
        }
    }
}