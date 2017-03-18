namespace hackathon.Models.User
{
    public interface IUsersRepository
    {
        void Register(string username, string seed);
        void LogIn(string username, string seed);
    }
}