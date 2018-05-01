using System;
using System.Collections.Generic;
using System.Text;
using DiplomaBack.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiplomaBack.DAL.EntityFrameworkCore
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base((DbContextOptions)options)
        {
        }
    }
}
