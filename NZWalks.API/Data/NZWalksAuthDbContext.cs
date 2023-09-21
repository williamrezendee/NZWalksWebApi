using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "9d350d26-09ee-47c7-9949-17d277bc4f1a";
            var writerRoleId = "808491fd-51d0-4c37-996b-23189a45dfb9";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
