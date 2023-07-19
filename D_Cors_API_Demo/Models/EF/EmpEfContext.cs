using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace D_Cors_API_Demo.Models.EF;

public partial class EmpEfContext : DbContext
{
    public EmpEfContext()
    {
    }

    public EmpEfContext(DbContextOptions<EmpEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmpInfo> EmpInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=EmpEF;integrated security= true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmpInfo>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__EmpInfo__AF2D66D3549B4E85");

            entity.ToTable("EmpInfo");

            entity.Property(e => e.EmpNo).ValueGeneratedNever();
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
