using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eM_Demo.Models;

public partial class EmployeeMngDbContext : DbContext
{
    public EmployeeMngDbContext()
    {
    }

    public EmployeeMngDbContext(DbContextOptions<EmployeeMngDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=labVMH8OX\\SQLEXPRESS;Database=employeeMngDb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admins__719FE488DB82FD92");

            entity.HasIndex(e => e.Email, "UQ__Admins__A9D1053438132177").IsUnique();

            entity.Property(e => e.ContactNumber).HasMaxLength(20);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasDefaultValue("Admin");
            entity.Property(e => e.Surname).HasMaxLength(100);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F1134D00A4D");

            entity.HasIndex(e => e.Email, "UQ__Employee__A9D10534C88CC5E4").IsUnique();

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.ContactNumber).HasMaxLength(20);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
