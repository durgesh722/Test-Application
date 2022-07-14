
using QBS_CORE_WEBAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QBS_CORE_WEBAPI.Data
{
    public class QbsContext : DbContext
    {
        public QbsContext(DbContextOptions options) : base(options)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ApplicationUsers>()
            // .Property(s => s.Mobile)
            // .HasColumnName("Mobile")
            // .HasDefaultValue("9958271070")
            // .IsRequired();

            //modelBuilder.Entity<Course>().ToTable("Course");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            //modelBuilder.Entity<Student>().ToTable("Student");
        }
    
        //entities
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
        public DbSet<tbl_user_m> tbl_user_m { get; set; }
        public DbSet<tbl_plan_m> tbl_Plan_Ms { get; set; }
        public DbSet<tbl_service_m> tbl_Service_Ms { get; set; }

      


    }
}
