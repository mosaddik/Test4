using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp4.Models;

namespace TestApp4.conext
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
