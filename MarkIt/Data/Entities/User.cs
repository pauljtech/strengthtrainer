using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkIt.Data.Entities
{
    // this is a temp class until IdentityFramework is implemented
    // to be deleted shortly
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Workout> Workouts { get; set; }
    }
}