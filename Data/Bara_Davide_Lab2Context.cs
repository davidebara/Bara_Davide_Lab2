using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bara_Davide_Lab2.Models;

namespace Bara_Davide_Lab2.Data
{
    public class Bara_Davide_Lab2Context : DbContext
    {
        public Bara_Davide_Lab2Context (DbContextOptions<Bara_Davide_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bara_Davide_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bara_Davide_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Bara_Davide_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Bara_Davide_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Bara_Davide_Lab2.Models.BookCategory>? BookCategory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }
        public DbSet<Bara_Davide_Lab2.Models.Member>? Member { get; set; }
        public DbSet<Bara_Davide_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
