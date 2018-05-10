﻿// <auto-generated />
using DiplomaBack.DAL.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DiplomaBack.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiplomaBack.DAL.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.Property<int>("TutorId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DiplomaBack.DAL.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SubjectId");

                    b.Property<DateTime>("TimeOfEnd");

                    b.Property<DateTime>("TimeOfStart");

                    b.Property<int>("TutorId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("DiplomaBack.DAL.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("DiplomaBack.DAL.Entities.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Rate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("DiplomaBack.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("Login");

                    b.Property<string>("MiddleName");

                    b.Property<string>("SecondName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
