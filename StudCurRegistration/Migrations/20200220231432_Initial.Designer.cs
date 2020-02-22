﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudCurRegistration;

namespace StudCurRegistration.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20200220231432_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudCurRegistration.Courses", b =>
                {
                    b.Property<int>("CourseCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CourseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseCode")
                        .HasName("PK_CourseCode");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudCurRegistration.studInfo", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudEmailAdd")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("StudEnrollFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StudFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudGender")
                        .HasColumnType("int");

                    b.Property<string>("StudPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StudStartDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("StudphNum")
                        .HasColumnType("bigint")
                        .HasMaxLength(10);

                    b.HasKey("StudentId")
                        .HasName("PK_StudentID");

                    b.ToTable("StudentInfo");
                });

            modelBuilder.Entity("StudCurRegistration.Courses", b =>
                {
                    b.HasOne("StudCurRegistration.studInfo", "StudInfo")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
