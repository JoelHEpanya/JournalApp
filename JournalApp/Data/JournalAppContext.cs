using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JournalApp.Models;

namespace JournalApp.Data
{
    public class JournalAppContext : DbContext
    {
        public JournalAppContext (DbContextOptions<JournalAppContext> options)
            : base(options)
        {
        }

        public DbSet<JournalApp.Models.Notes> Notes { get; set; } = default!;
        public DbSet<JournalApp.Models.Meals> Meals { get; set; } = default!;
        public DbSet<JournalApp.Models.Dreams> Dreams { get; set; } = default!;
    }
}
