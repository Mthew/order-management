using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OrdersManagement.Entity.Models;

public partial class DbOrdersContext : DbContext
{
    public DbOrdersContext()
    {
    }

    public DbOrdersContext(DbContextOptions<DbOrdersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.; database=db_orders; User ID=ticket; Password=12345; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__orders__3213E83F229DE22A");

            entity.ToTable("orders");

            entity.HasIndex(e => e.OrderNumber, "UQ__orders__6296129FBD7D0502").IsUnique();

            entity.HasIndex(e => e.OmNumber, "UQ__orders__F6638CD69E8679FF").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Generic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("generic");
            entity.Property(e => e.OmNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("omNumber");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("orderNumber");
            entity.Property(e => e.OrderState).HasColumnName("orderState");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__orderDet__3213E83F5C09BED7");

            entity.ToTable("orderDetails");

            entity.HasIndex(e => e.BarCode, "UQ__orderDet__38AAAA62F6EEA474").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("barCode");
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.ColorCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colorCode");
            entity.Property(e => e.ConfirmedQuantity)
                .HasDefaultValueSql("((0))")
                .HasColumnName("confirmedQuantity");
            entity.Property(e => e.OfNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ofNumber");
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.RealQuantity).HasColumnName("realQuantity");
            entity.Property(e => e.Size)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("size");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.UmQuantity).HasColumnName("umQuantity");
            entity.Property(e => e.Variant)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("variant");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__orderDeta__order__37A5467C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
