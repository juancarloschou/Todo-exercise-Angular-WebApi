using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TodoApi.Models.DB
{
    public partial class TodoContext : DbContext
    {
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<TodoItems> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=AJU-PC;Initial Catalog=Todo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Address1).HasColumnType("varchar(50)");

                entity.Property(e => e.Address2).HasColumnType("varchar(50)");

                entity.Property(e => e.City).HasColumnType("varchar(30)");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(30)");

                entity.Property(e => e.Gender).HasColumnType("varchar(10)");

                entity.Property(e => e.LastName).HasColumnType("varchar(30)");

                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.State).HasColumnType("varchar(30)");

                entity.Property(e => e.Zip).HasColumnType("nchar(10)");
            });
        }
    }
}