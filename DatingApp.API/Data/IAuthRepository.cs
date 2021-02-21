using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<UserDetail> Register (UserDetail user);
         Task<UserDetail> Login (string username,string password);
         Task<bool> UserExists (string username);
         Task<bool> EmailExists(string email);
    }
}