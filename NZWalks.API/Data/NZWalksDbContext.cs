using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium and Hard
            var difficulties = new List<Difficulty>
            {
                new Difficulty
                {
                    Id = Guid.Parse("d540cc5f-695f-4574-a344-a84e71b19245"),
                    Name = "Easy"
                },
                new Difficulty
                {
                    Id = Guid.Parse("a92fae55-9d0b-42c2-9059-ad8a9ff2f9fd"),
                    Name = "Medium"
                },
                new Difficulty
                {
                    Id = Guid.Parse("9888c8e3-a1f9-41a8-bf33-51408b8f2b6f"),
                    Name = "Hard"
                },
            };
            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("c030fb34-6cc6-4165-9431-68f5914d48c4"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("939a074a-4bc7-4254-a669-ac4d473b9f56"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("e91d50f3-0884-436f-86af-28927d34b1e9"),
                    Name = "Bay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("5bbe10c0-b919-4d6e-bec4-7829bc31354b"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("7d687386-1603-4033-850d-a0a7af0645df"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("51d30169-4e7e-45b4-adf6-1cd23d218f9f"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
