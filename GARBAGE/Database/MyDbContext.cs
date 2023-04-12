using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GARBAGE.ViewModels;
using GARBAGE.Models;
using Bogus;

namespace GARBAGE.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserModel> Authors { get; set; }
        public DbSet<UserModel> Items { get; set; }
        public DbSet<UserModel> Images { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            }
            optionsBuilder.UseLazyLoadingProxies();
            // To be disabled in production
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Table building logic for EF code-first with data seeding
            var ids = 1;
            var roles = new int[] {1,2};
            var users = new Faker<UserModel>()
                .RuleFor(u => u.Id, f => ids++)
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Role, f => f.PickRandom(roles))
                .RuleFor(u => u.Phonenumber, f => f.Random.Number(1000000));

            // generate 100 users
            modelBuilder
                .Entity<UserModel>()
                .HasData(users.GenerateBetween(100, 100));

            modelBuilder.Entity<ImgModel>();
            modelBuilder.Entity<AuthorModel>();
            modelBuilder.Entity<ItemModel>();
            base.OnModelCreating(modelBuilder);
        }
    }
}