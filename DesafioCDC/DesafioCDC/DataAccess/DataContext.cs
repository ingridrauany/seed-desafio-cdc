﻿using DesafioCDC.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioCDC.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Author>()
                .Property(e => e.Name)
                .IsRequired();

            modelBuilder.Entity<Author>()
                .Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(400);

            modelBuilder.Entity<Author>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}