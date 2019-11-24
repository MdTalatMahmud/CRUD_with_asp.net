using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class ProjectDB:DbContext
    {
        public ProjectDB() : base("UDB")
        {
            
        }

        public DbSet<Student> Students { get; set; }
            //DbSet means DatabaseTableSet
            //Students <= it is a reference

    }
}