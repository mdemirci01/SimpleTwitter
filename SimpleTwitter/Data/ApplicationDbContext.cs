using Microsoft.EntityFrameworkCore;
using SimpleTwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTwitter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SimpleTwitter.Models.Tweet> Tweets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
