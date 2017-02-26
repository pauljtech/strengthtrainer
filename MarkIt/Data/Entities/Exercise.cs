using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkIt.Data.Entities
{
    public enum ExerciseType
    {
        Weights,
        BodyWeight,
        Stretch,
        Cardio,
        HighIntensity
    }

    public class Exercise
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ExerciseType ExerciseType { get; set; }
    }

    // in case user wants to log exercises not in the MarkIt database
    public class CustomExercise
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}