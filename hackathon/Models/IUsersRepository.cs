using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Models
{
    public interface IUsersRepository
    {
        IEnumerable<User> Get();
        bool Register(string username, string seed);
        bool Login(string username, string seed);
        IEnumerable<Cloth> GetCloths(long id);
    }
}