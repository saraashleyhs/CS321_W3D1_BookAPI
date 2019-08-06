using System;
using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CS321_W3D1_BookAPI.Data
{
    public class BookContext : DbContext
    {
        // TODO: implement a DbSet<Book> property
        public DbSet<Book> Books { get; set; }

        // This method runs once when the DbContext is first used.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: use optionsBuilder to configure a Sqlite db
            optionsBuilder.UseSqlite("Data Source= Book.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: configure some seed data in the books table
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Grapes of Wrath", Author = "John Steinbeck", Category = "Historical Fiction" },
                new Book { Id = 2, Title = "Cannery Row", Author = "John Steinbeck", Category = "Historical Fiction" },
                new Book { Id = 3, Title = "The Shining", Author = "Stephen King", Category = "Horror" },
                new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Category = "Adventure" });

        }

    }
}

