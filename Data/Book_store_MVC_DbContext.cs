using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_store_MVC_.Models;

namespace Book_store_MVC_.Data
{
    public class Book_store_MVC_DbContext : DbContext
    {
        public Book_store_MVC_DbContext (DbContextOptions<Book_store_MVC_DbContext> options)
            : base(options)
        {
        }

        public DbSet<Book_store_MVC_.Models.Book> Book { get; set; }

        public DbSet<Book_store_MVC_.Models.Author> Author { get; set; }

        public DbSet<Book_store_MVC_.Models.Publication> Publication { get; set; }

        public DbSet<Book_store_MVC_.Models.Publisher> Publisher { get; set; }
    }
}
