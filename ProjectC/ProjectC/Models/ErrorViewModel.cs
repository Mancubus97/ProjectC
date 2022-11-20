using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;



namespace ProjectC.Models
{
    public record Innovation(Guid id, string name) { } //A Guid is like an int. Was recommended by a teacher to use for ID's.

    public class MyDbContext : DbContext
    {
        public DbSet<Innovation> innovations { get; set; }
        public DbSet<Account> accounts { get; set; }

        public MyDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql(@"Host=4.tcp.eu.ngrok.io:17458;Username=postgres;Password=;Database=projectc-db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EF");
            modelBuilder.Entity<Innovation>().HasKey(_ => _.id);
            modelBuilder.Entity<Account>().HasKey(_ => _.id);

        }

    }
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }


    
}