using System.Collections.Generic;

namespace hackathon.Models
{
    public interface IClothsRepository
    {
        IEnumerable<Cloth> Get();
        void Add(Cloth cloth);
    }
}