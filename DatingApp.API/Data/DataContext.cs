using DatingApp.API.Models;
using DatingApp.API.Models.SendModels;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
        public DbSet<UserDetail> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}