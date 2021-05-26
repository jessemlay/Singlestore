using Microsoft.EntityFrameworkCore;

namespace SingleStore.Models
{
	public class SingleStoreDataContext : DbContext
    {
        public SingleStoreDataContext(DbContextOptions<SingleStoreDataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("server=localhost;database=acme;user=root;password=admin");
        }

        public DbSet<Message> Messages { get; set; }
    }
}
