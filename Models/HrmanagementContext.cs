using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HRManagement.Models;
using System.Drawing;

namespace HRManagement.Models;

public partial class HrmanagementContext : DbContext
{
  

    public HrmanagementContext(DbContextOptions<HrmanagementContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server  =.\\SQLEXPRESS;Database=HRManangement;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


  
    public DbSet<Employee> Employees { get; set; }
}
