using System;

namespace hackathon.Models.User
{
    public class UsersRepository : IUsersRepository
    {

        private readonly WasherDb _context;

        public UsersRepository(WasherDb context)
        {
            _context = context;
            Register("janusz", "123123123123");
        }

        public void Register(string username, string seed)
        {
            _context.Add(new User {Username = username, Seed = seed});
        }

        public void LogIn(string username, string seed)
        {
            throw new NotImplementedException();
        }
    }
}