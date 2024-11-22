using Microsoft.EntityFrameworkCore;

namespace JasmineLeaf.Models
{
	public class LeafContext : DbContext
	{
		public DbSet<Leaf> Leaves { get; set; }
		public DbSet<Request> Requests { get; set; }

		public LeafContext(DbContextOptions<LeafContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// Additional configurations if needed
		}
	}

}
