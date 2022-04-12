using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreDemo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDemo.API.DbContexts
{
    public class EFcoreDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Department>  Department { get; set; }
        public EFcoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected EFcoreDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //忽略映射某个字段
            //modelBuilder.Entity<Department>(op=>op.Ignore("Description"));
        }
    }
}