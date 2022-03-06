using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Linq_labb2.Models;

namespace Linq_labb2.Data
{
    class SkolanEFDBContext : DbContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-RTVA969K;Initial Catalog=CampusVarberg;Integrated Security = True;");
        }
    }
}
