using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project1
{
    public class StudentDBContext : DbContext
    {
        // StudentDBContext class must inherit from DbContext
        // present in System.Data.Entity namespace
        
            public DbSet<Department> Departments { get; set; }
            public DbSet<Student> Students { get; set; }
        
    }
}