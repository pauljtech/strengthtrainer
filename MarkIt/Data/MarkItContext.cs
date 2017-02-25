using MarkIt.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MarkIt.Data
{
    public class MarkItContext : DbContext
    {

        public MarkItContext() : base("MarkItContext")
        {
        }

        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
