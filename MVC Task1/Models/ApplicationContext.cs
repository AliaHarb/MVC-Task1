using Microsoft.EntityFrameworkCore;
using MVC_Task1.Models;
using System.Collections.Generic;

namespace WebApplication1.Models

{
    public class Applicationcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q3BLPMA\\ALIA;Database=MvcTask1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData
                (
                new Course { CourseId = 1, CourseName = "Math 101", CourseCode = "MATH101", Credits = 3, Description = "Basic Math" },
                new Course { CourseId = 2, CourseName = "CS 101", CourseCode = "CS101", Credits = 4, Description = "Intro to Programming" }
            );


        }
    }
}
