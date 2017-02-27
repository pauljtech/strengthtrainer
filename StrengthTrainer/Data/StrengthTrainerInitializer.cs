using StrengthTrainer.Data.Entities;
using System;
using System.Collections.Generic;

namespace StrengthTrainer.Data
{
    public class StrengthTrainerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StrengthTrainerContext>
    {
        protected override void Seed(StrengthTrainerContext context)
        {

            // seed Exercise table
            var exerciseOneArmRows = new Exercise { ExerciseType = ExerciseType.Weights, Title = "One Arm Rows" };
            var exerciseBenchPress = new Exercise { ExerciseType = ExerciseType.Weights, Title = "Bench Press" };
            var exercisePullovers = new Exercise { ExerciseType = ExerciseType.Weights, Title = "Pullovers" };
            var exerciseDumbbellFlys = new Exercise { ExerciseType = ExerciseType.Weights, Title = "Dumbbell Flys" };

            var exercises = new List<Exercise> { exerciseOneArmRows, exerciseBenchPress, exercisePullovers, exerciseDumbbellFlys };

            exercises.ForEach(x => context.Exercises.Add(x));
            context.SaveChanges();

            // seed User table (will be replaced soon)
            var userPaul = new User { Name = "Paul Johnson" };
            var userFirst = new User { Name = "First User" };

            var users = new List<User>
            {
                userPaul,
                userFirst
            };

            users.ForEach(x => context.Users.Add(x));
            context.SaveChanges();

            // seed Workout table
            var workouts = new List<Workout>
            {
                new Workout { Id = 1, UserId = userPaul.Id, StartDateTime = DateTime.Now }
            };

            workouts.ForEach(x => context.Workouts.Add(x));
            context.SaveChanges();

            // seed WorkoutExercises table
            var workoutExercises = new List<WorkoutExercise>()
            {
                new WorkoutExercise { Id = 1, WorkoutId = 1, ExerciseId = exerciseOneArmRows.Id },
                new WorkoutExercise { Id = 2, WorkoutId = 1, ExerciseId = exerciseBenchPress.Id },
                new WorkoutExercise { Id = 3, WorkoutId = 1, ExerciseId = exercisePullovers.Id },
                new WorkoutExercise { Id = 4, WorkoutId = 1, ExerciseId = exerciseDumbbellFlys.Id }
            };

            workoutExercises.ForEach(x => context.WorkoutExercises.Add(x));
            context.SaveChanges();

            // seed Sets table
            var startDate = DateTime.Now;

            var workoutExerciseSets = new List<Set>()
            {
                new Set { WorkoutExerciseId = 1, Number = 1, Weight = 50, WeightType = WeightType.Pounds, Reps = 15, StartDateTime = DateTime.Now },
                new Set { WorkoutExerciseId = 1, Number = 2, Weight = 50, WeightType = WeightType.Pounds, Reps = 15, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 1, Number = 3, Weight = 50, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 2, Number = 1, Weight = 100, WeightType = WeightType.Pounds, Reps = 14, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 2, Number = 2, Weight = 100, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 2, Number = 3, Weight = 100, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 3, Number = 1, Weight = 50, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 3, Number = 2, Weight = 50, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 3, Number = 3, Weight = 50, WeightType = WeightType.Pounds, Reps = 10, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 4, Number = 1, Weight = 40, WeightType = WeightType.Pounds, Reps = 15, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 4, Number = 2, Weight = 40, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) },
                new Set { WorkoutExerciseId = 4, Number = 3, Weight = 40, WeightType = WeightType.Pounds, Reps = 12, StartDateTime = startDate.AddMinutes(2) }
            };

            workoutExerciseSets.ForEach(x => context.Sets.Add(x));
            context.SaveChanges();
        }
    }
}