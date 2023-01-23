using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
#pragma warning disable CS1591

    /// <summary>
    /// This is DemoContext class derived from DbContext class
    /// </summary>
    public class DemoContext : DbContext
    {
        internal readonly object Office;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Demo.Models.Emp> Emp { get; set; }
        public DbSet<Demo.Models.Office> Offices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>().HasData(
                new Emp()
                {
                    Id = 1,
                    Name ="ABC"
                }, new Emp()
                {
                    Id = 2,
                    Name = "ABCD"
                });
            modelBuilder.Entity<Office>().HasData(
                  new Office()
                  {
                      Id = 1,
                      Location = "Pune",
                      EmpId = 1
                  });
            modelBuilder.Entity<Office>().HasData(
                  new Office()
                  {
                      Id = 2,
                      Location = "Delhi",
                      EmpId = 2
                  });

            //    base.OnModelCreating(modelBuilder);
        }

     
    }
}
