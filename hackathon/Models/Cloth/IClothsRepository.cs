using System.Collections;
using System.Collections.Generic;
using hackathon.Models;

namespace hackathon {
    public interface IClothsRepository {
        IEnumerable<Cloth> Get();
        void Add(Cloth cloth);
    }
}