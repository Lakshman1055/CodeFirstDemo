﻿using CodeFirstDemo.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.DataAccess
{
    public class PlutoContext : DbContext
    {
        public PlutoContext():base("name=DefaultConnection")
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Tag> Tags{ get; set; }

    }
}
