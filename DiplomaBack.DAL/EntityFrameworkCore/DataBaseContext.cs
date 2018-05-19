using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DiplomaBack.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiplomaBack.DAL.EntityFrameworkCore
{
    public class DataBaseContext : DbContext
    {
    public DbSet<User> Users { get; set; }
      public DbSet<Tutor> Tutors { get; set; }
      public DbSet<Subject> Subjects { get; set; }
      public DbSet<Lesson> Lessons { get; set; }
      public DbSet<Comment> Comments { get; set; }


    public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base((DbContextOptions)options)
        {
        }
    }
}
