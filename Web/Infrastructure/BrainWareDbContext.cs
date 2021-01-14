using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Infrastructure
{
    public class BrainWareDbContext:DbContext
    {
        public BrainWareDbContext():base("BrainWareDbContext")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}