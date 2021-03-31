using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_store_MVC_.Data
{
    public class bookstoreDbContext : DbContext
    {
        public bookstoreDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book_store_MVC_.Models.Author> Author { get; set; }

        public DbSet<Book_store_MVC_.Models.Book> Book { get; set; }

        public DbSet<Book_store_MVC_.Models.Publication> Publication { get; set; }

        public DbSet<Book_store_MVC_.Models.Publisher> Publisher { get; set; }
    }
}
