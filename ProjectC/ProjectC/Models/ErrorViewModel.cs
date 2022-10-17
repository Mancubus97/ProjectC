using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace ProjectC.Models
{
    public record Innovation(Guid id, string name) { } //A Guid is like an int. Was recommended by a teacher to use for ID's.
    public record User(Guid id, string username, string password) { }
    public record Admin(Guid id, string username, string password) { }

    public class MyDbContext : DbContext
    {
        public DbSet<Innovation> innovations { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Admin> admins { get; set; }

        public MyDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost:5432;Username=postgres;Password=;Database=projectc-db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EF");
            modelBuilder.Entity<Innovation>().HasKey(_ => _.id);
            modelBuilder.Entity<User>().HasKey(_ => _.id);
            modelBuilder.Entity<Admin>().HasKey(_ => _.id);
        }

    }
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }


    
}