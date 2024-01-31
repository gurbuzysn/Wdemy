using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Entities;

namespace Wdemy.Persistence.Context
{
    public class WdemyDbContext : DbContext
    {
        public WdemyDbContext(DbContextOptions<WdemyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Admin> Admins => Set<Admin>();
        public DbSet<Trainer> Trainers => Set<Trainer>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<SubCategory> SubCategories => Set<SubCategory>();
        public DbSet<Subject> Subjects => Set<Subject>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
