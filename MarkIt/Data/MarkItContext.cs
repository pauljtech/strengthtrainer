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
        public DbSet<User> Users { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

        public DbSet<Set> Sets { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
