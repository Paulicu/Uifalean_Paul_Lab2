using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uifalean_Paul_Lab2.Models;

namespace Uifalean_Paul_Lab2.Data
{
    public class Uifalean_Paul_Lab2Context : DbContext
    {
        public Uifalean_Paul_Lab2Context (DbContextOptions<Uifalean_Paul_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Uifalean_Paul_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Uifalean_Paul_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Uifalean_Paul_Lab2.Models.Author>? Author { get; set; } = default!;

        public DbSet<Uifalean_Paul_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Uifalean_Paul_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Uifalean_Paul_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
