using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookCollection.Models;

namespace BookCollection.Data
{
    public class BookCollectionContext : DbContext
    {
        public BookCollectionContext (DbContextOptions<BookCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<BookCollection.Models.Author> Author { get; set; } = default!;
        public DbSet<BookCollection.Models.Book> Book { get; set; } = default!;
    }
}
