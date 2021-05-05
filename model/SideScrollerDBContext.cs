using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideScroller.model
{
    public class SideScrollerDBContext : DbContext
    {
        public DbSet<highscore> Highscores { get; set; }
        public DbSet<player> Players { get; set; }
        public DbSet<blockcades> Blockcades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@$"Server=PC-BB-5987;Database=Sidescroller;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
