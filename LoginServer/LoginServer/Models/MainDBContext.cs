using LoginServer.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginServer.Models
{
    public class MainDBContext : IdentityDbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}
