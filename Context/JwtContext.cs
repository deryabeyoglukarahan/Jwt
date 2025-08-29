using Jwt.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jwt.Context
{
    public class JwtContext:IdentityDbContext
    {
        public JwtContext(DbContextOptions<IdentityDbContext>options):base(options)
        {
            
        }
        public DbSet<UserEntity> Users { get; set; }
    }
}
