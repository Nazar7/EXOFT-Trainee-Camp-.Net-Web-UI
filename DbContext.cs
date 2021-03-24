using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    public class MyContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<Category>().ToTable("Categorys");
        }
    }
}
