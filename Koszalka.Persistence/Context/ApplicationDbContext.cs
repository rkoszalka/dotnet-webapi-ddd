using Koszalka.Domain.Entities;
using Koszalka.WebAPI.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Koszalka.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<ApplicationUser> AppUser { get; set; }
    }
}
