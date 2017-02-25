using MarkIt.Data.Entities;
using System;
using System.Collections.Generic;

namespace MarkIt.Data
{
    public class MarkItInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MarkItContext>
    {
        protected override void Seed(MarkItContext context)
        {
            var workouts = new List<Workout>
            {
                new Workout { Date = DateTime.Now } 
            };

            workouts.ForEach(x => context.Workouts.Add(x));
            context.SaveChanges();
        }
    }
}