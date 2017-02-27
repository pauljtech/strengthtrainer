using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrengthTrainer.Data.Entities
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
}