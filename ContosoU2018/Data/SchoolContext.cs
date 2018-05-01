using ContosoU2018.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        { } 
        public DbSet<person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Istructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
           
    }
}

