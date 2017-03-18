using System.Collections.Generic;
using System.Linq;
using hackathon.Models;

namespace hackathon.Controllers
{
    public class ClothsRepository : IClothsRepository
    {
        private readonly WasherDb _context;

        public ClothsRepository(WasherDb context)
        {
            _context = context;
            Add(new Cloth {Name = "black shirt", Type = "shirt"});
        }

        public IEnumerable<Cloth> Get()
        {
            return _context.Cloths.ToList();
        }

        public void Add(Cloth cloth)
        {
            _context.Cloths.Add(cloth);
            _context.SaveChanges();
        }
    }
}