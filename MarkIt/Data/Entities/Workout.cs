using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkIt.Data.Entities
{
    public class Workout
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        
        public virtual User User { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        // e.g., "Arm Day" or "Leg Day 1" or "Ab Circuit"
        public string Title { get; set; }

        // a sequential count of a user's workouts
        public string Number { get; set; }

        public virtual ICollection<WorkoutExercise> Exercises { get; set; }

        public int? TemplateId { get; set; }

        public virtual WorkoutExerciseTemplate Template { get; set; }
    }

    public class WorkoutExercise
    {
        public int Id { get; set; }

        public int WorkoutId { get; set; }

        public virtual Workout Workout { get; set; }

        public virtual ICollection<Set> Sets { get; set; }

        public int ExerciseId { get; set; }

        public virtual Exercise Exercise { get; set; }
    }

    // todo, for pre-creating a workout
    public class WorkoutExerciseTemplate
    {
        public int Id { get; set; }

        // you can get Exercise Title, type, etc from this link
        public int ExerciseId { get; set; }

        public virtual Exercise Exercise { get; set; }

        public int NumberOfSets { get; set; }

        public int? GoalRepsPerSet { get; set; }

        //public WeightType? WeightType { get; set; }

        public int GoalWeightPerSet { get; set; }
    }
}