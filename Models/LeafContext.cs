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
            base.OnModelCreating(modelBuilder);
            var Kolis = LoadChickenDataFromJson();
            modelBuilder.Entity<Koli>().HasData(Kolis);
        }

        private List<Koli> LoadChickenDataFromJson()
        {
            var jsonFilePath = Path.Combine(AppContext.BaseDirectory, "SeedData", "KoliData.json");
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonSerializer.Deserialize<List<Koli>>(jsonData);
        }

    }

}
