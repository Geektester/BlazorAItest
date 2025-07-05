using System.Threading.Tasks;
using test1;
using test1.Models;

namespace test1.Services
{
    public class AuthService
    {
        private readonly SessionState _session;

        public AuthService(SessionState session)
        {
            _session = session;
        }

        public Task<bool> Register(User user)
        {
            // Normally you'd call a backend API here
            return Task.FromResult(true);
        }

        public Task<bool> Login(string username, string password)
        {
            // Mock logic
            if (username == "test" && password == "123456")
            {
                _session.SetUser(username);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}