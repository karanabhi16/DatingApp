using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using static DatingApp.API.Data.Helper;

namespace DatingApp.API.Data.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<User> Login(string username, string password)
        {
            // ReSharper disable once ReplaceWithSingleCallToSingleOrDefault
            string hashedPass = _context.Users.Where(x => x.Username.ToLower() == username).SingleOrDefault().Password;
            var valRes = SecurePasswordHasherHelper.Verify(password, hashedPass);
            if (!valRes)
            {
               return null;
            }
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username.ToLower() == username);
            return user; 
        }

        public async Task<User> Register(User user)
        {
            user.Password = SecurePasswordHasherHelper.Hash(user.Password);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.Username == username))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> EmailExists(string email)
        {
            if (await _context.Users.AnyAsync(x => x.Email == email))
            {
                return true;
            }
            return false;
        }
    }
}