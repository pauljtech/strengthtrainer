using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkIt.Data.Entities
{
    public class Set
    {
        public int Id { get; set; }

        public int WorkoutExerciseId { get; set; }

        public virtual WorkoutExercise WorkoutExercise { get; set; }

        public int Number { get; set; }

        // bodyweight exercises, e.g., pushups and stretches won't record a weight
        // Weight is per rep
        public double? Weight { get; set; }

        public WeightType? WeightType { get; set; }

        public int Reps { get; set; }
        
        // this should be automatic, a timestamp
        public DateTime StartDateTime { get; set; }
        
        // for planks, stretches, pilates, yoga poses, etc, that are for a duration
        public DateTime? EndDateTime { get; set; }

        public string Notes { get; set; }
    }

    public enum WeightType
    {
        Pounds,
        Kilograms
    }
}