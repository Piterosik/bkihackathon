using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mysqlx;

namespace hackathon.Models
{
    public class UsersRepository : IUsersRepository
    {
        private readonly WasherDb _context;

        public UsersRepository(WasherDb context)
        {
            _context = context;
        }

        public bool Register(string username, string seed)
        {
            if (_context.Users.FirstOrDefault(t => t.Username == username) != null) return false;
            _context.Add(new User { Username = username, Seed = seed });
            _context.SaveChanges();
            return true;
        }

        public bool Login(string username, string seed)
        {
            return _context.Users.FirstOrDefault(t => t.Username == username) != null && _context.Users.FirstOrDefault(t => t.Seed == seed) != null;
        }

        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }

        public IEnumerable<Cloth> GetCloths(long id)
        {
            return _context.Cloths.Where(t => t.UserId == id).ToList();
        }
    }
}