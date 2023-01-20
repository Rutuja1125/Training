using Microsoft.EntityFrameworkCore;

namespace StudentProject1.Models
{
    //Inheriting AppDbContext class from  DbContext class
    //DbContext is part of EntityFrameworkCore.
    //This will allow to create DbSet where DbSet will accept values and create a db with the entered values.

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    FirstName = "A",
                    LastName = "a",
                    Email = "A.a@gmail.com",
                    DepartmentId = "CS1",
                    gender = Gender.Male,

                },
                new Student()
                {

                    StudentId = 2,
                    FirstName = "b",
                    LastName = "b",
                    Email = "B.b@gmail.com",
                    DepartmentId = "CS2",
                    gender = Gender.Female,
                });

        }

    }
}
