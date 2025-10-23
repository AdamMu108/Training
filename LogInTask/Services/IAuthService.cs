
using LogInTask.Models;

namespace LogInTask.Services
{

    public interface IAuthService
    {
        Task<(bool success, string message)> LoginAsync(string username, string password, string otp = null);
        User? GetUserByUsername(string username);
        User? GetUserByEmail(string Email);

    }

}