using System.Collections.Generic;
using System.Linq;
using hackathon.Models;

namespace hackathon.Models
{
    public class ClothsRepository : IClothsRepository
    {
        private readonly WasherDb _context;

        public ClothsRepository(WasherDb context)
        {
            _context = context;
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