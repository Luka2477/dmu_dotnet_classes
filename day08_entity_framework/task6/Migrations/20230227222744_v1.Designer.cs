﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using task6.DAL;

#nullable disable

namespace task6.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20230227222744_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.Property<int>("ClassesID")
                        .HasColumnType("int");

                    b.Property<int>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("ClassesID", "StudentsID");

                    b.HasIndex("StudentsID");

                    b.ToTable("ClassStudent");
                });

            modelBuilder.Entity("task6.Models.Class", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Title = "Maths"
                        },
                        new
                        {
                            ID = 2,
                            Title = "Physics"
                        },
                        new
                        {
                            ID = 3,
                            Title = "Danish"
                        });
                });

            modelBuilder.Entity("task6.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Lukas"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Mads"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Mike"
                        });
                });

            modelBuilder.Entity("task6.Models.StudentClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentClasses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClassID = 1,
                            StudentID = 1
                        },
                        new
                        {
                            ID = 2,
                            ClassID = 2,
                            StudentID = 1
                        },
                        new
                        {
                            ID = 3,
                            ClassID = 1,
                            StudentID = 2
                        },
                        new
                        {
                            ID = 4,
                            ClassID = 3,
                            StudentID = 2
                        },
                        new
                        {
                            ID = 5,
                            ClassID = 1,
                            StudentID = 3
                        },
                        new
                        {
                            ID = 6,
                            ClassID = 2,
                            StudentID = 3
                        },
                        new
                        {
                            ID = 7,
                            ClassID = 3,
                            StudentID = 3
                        });
                });

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.HasOne("task6.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("task6.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("task6.Models.StudentClass", b =>
                {
                    b.HasOne("task6.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("task6.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
