using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudCurRegistration
{
    public class SchoolContext : DbContext
    {
        public DbSet<studInfo> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }

        public SchoolContext()
        { 
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
        { 
      
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                Initial Catalog=SchoolInfoDB;Integrated Security=True;
                                 Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<studInfo>(entity =>
            {
                entity.ToTable("StudentInfo");
                entity
                    .HasKey(e => e.StudentId)
                    .HasName("PK_StudentID");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StudEmailAdd)
                     .IsRequired()
                     .HasMaxLength(50);                               

                entity.Property(e => e.StudGender)
                    .IsRequired();

                entity.Property(e => e.StudFirstName)
                    .IsRequired();

                entity.Property(e => e.StudphNum)
                    .HasMaxLength(10);

                entity.Property(e => e.StudEnrollFee)
                    .IsRequired();
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.ToTable("Courses");

                entity
                    .HasKey(e => e.CourseCode)
                    .HasName("PK_CourseCode");

                entity.Property(e => e.CourseCode)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CourseDate)
                    .IsRequired();

                entity.HasOne(e => e.StudInfo)
                    .WithMany()
                    .HasForeignKey(e => e.StudentId);
            });
        }
    }
}
