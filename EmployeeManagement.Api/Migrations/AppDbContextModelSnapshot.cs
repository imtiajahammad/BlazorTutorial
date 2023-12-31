﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("Departmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Departmentid"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Departmentid");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Departmentid = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            Departmentid = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            Departmentid = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            Departmentid = 4,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "David@pragimtech.com",
                            FirstName = "John",
                            Gender = 0,
                            Lastname = "Hastings",
                            PhotoPath = "images/john.png"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "sam@pragimtech.com",
                            FirstName = "Sam",
                            Gender = 0,
                            Lastname = "Galloway",
                            PhotoPath = "images/sam.png"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "mary@pragimtech.com",
                            FirstName = "Mary",
                            Gender = 1,
                            Lastname = "Smith",
                            PhotoPath = "images/mary.png"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 1,
                            Lastname = "Longway",
                            PhotoPath = "images/sara.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
