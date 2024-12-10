using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace JasmineLeaf.Models
{
    public class LeafContext : DbContext
    {
        public DbSet<Leaf> Leaves { get; set; }
        public DbSet<Koli> Kolis { get; set; }
        public DbSet<Request> Requests { get; set; }

        public LeafContext(DbContextOptions<LeafContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Leaf data
            var Leaves = LoadLeafDataFromJson();
            modelBuilder.Entity<Leaf>().HasData(Leaves);

            // Seed Koli data
            var Kolis = LoadChickenDataFromJson();
            modelBuilder.Entity<Koli>().HasData(Kolis);

            base.OnModelCreating(modelBuilder);
        }


        private List<Leaf> LoadLeafDataFromJson()
        {
            var jsonFilePath = Path.Combine(AppContext.BaseDirectory, "SeedData", "LeafData.json");
            var jsonData = File.ReadAllText(jsonFilePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<Leaf>>(jsonData, options);
        }
        private List<Koli> LoadChickenDataFromJson()
        {
            var jsonFilePath = Path.Combine(AppContext.BaseDirectory, "SeedData", "KoliData.json");
            var jsonData = File.ReadAllText(jsonFilePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<Koli>>(jsonData, options);
        }


    }

}
