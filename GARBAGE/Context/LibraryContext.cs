using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GARBAGE.Models;

namespace GARBAGE.Context
{
    internal class LibraryContext : DbContext
    {
        public LibraryContext() 
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //entities
        public DbSet<UserModel> Usermodel { get; set; }
        public DbSet<AuthorModel> Authormodel { get; set; }
        public DbSet<ItemModel> Itemmodel { get; set; }
        public DbSet<ImgModel> Imgmodel { get; set; }
    }
}
