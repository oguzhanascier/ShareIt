using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShareIt.Models
{
    public class ShareContext:IdentityDbContext<User,UserRole, int>
    {
        public ShareContext(DbContextOptions<ShareContext>options):base(options)
        {}
        public DbSet<Sharing> Sharings {get; set;}
    }
}