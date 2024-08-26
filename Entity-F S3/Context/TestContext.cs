using Entity_F_S1.Entities;
using Entity_F_S3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S3.Context
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ItiM2MRelationShip ; Trusted_Connection = True ; Encrypt = False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region RelationShip M2M With Student,Course
            modelBuilder.Entity<Student>()
                        .HasMany(s => s.stud_Courses)
                        .WithOne(s => s.student);
                        //.HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<Course>()
                        .HasMany(c => c.stud_Courses)
                        .WithOne(sc => sc.course);
                        //.HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Stud_Course>()
                        .HasKey(s => new { s.StudentId, s.CourseId });


            #endregion
            #region RelationShip M2M With Course,Instructor
            modelBuilder.Entity<Course>()
                        .HasMany(c => c.course_Instructors)
                        .WithOne(ci => ci.course);
                        //.HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Instructor>()
                        .HasMany(i => i.course_Instructors)
                        .WithOne(ci => ci.instructor);
                        //.HasForeignKey(i => i.InstructorId);
            modelBuilder.Entity<Course_Instructor>()
                        .HasKey(ci => new { ci.InstructorId, ci.CourseId });
            #endregion
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Stud_Course> studentCourse { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course_Instructor> courseInstructors { get; set; }

    }
}
