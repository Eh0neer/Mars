using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mars;

public partial class MarsDbContext : DbContext
{
    public MarsDbContext()
    {
    }

    public MarsDbContext(DbContextOptions<MarsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cashorder> Cashorders { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<Employeecard> Employeecards { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Orderitem> Orderitems { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Shiftassignment> Shiftassignments { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Usertype> Usertypes { get; set; }

    public virtual DbSet<Waiterassignment> Waiterassignments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MarsDB;Username=postgres;Password=2804");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cashorder>(entity =>
        {
            entity.HasKey(e => e.Cashorderid).HasName("cashorders_pkey");

            entity.ToTable("cashorders");

            entity.Property(e => e.Cashorderid).HasColumnName("cashorderid");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Paymentmethod)
                .HasMaxLength(255)
                .HasColumnName("paymentmethod");

            entity.HasOne(d => d.Order).WithMany(p => p.Cashorders)
                .HasForeignKey(d => d.Orderid)
                .HasConstraintName("cashorders_orderid_fkey");
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasKey(e => e.Dishid).HasName("dishes_pkey");

            entity.ToTable("dishes");

            entity.Property(e => e.Dishid).HasColumnName("dishid");
            entity.Property(e => e.Dishname)
                .HasMaxLength(255)
                .HasColumnName("dishname");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
        });

        modelBuilder.Entity<Employeecard>(entity =>
        {
            entity.HasKey(e => e.Employeecardid).HasName("employeecards_pkey");

            entity.ToTable("employeecards");

            entity.Property(e => e.Employeecardid).HasColumnName("employeecardid");
            entity.Property(e => e.Employmentcontractscan).HasColumnName("employmentcontractscan");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Employeecards)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("employeecards_userid_fkey");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Orderid).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Orderdate).HasColumnName("orderdate");

            // Use the Enum string representation for PostgreSQL
            entity.Property(e => e.PaymentMethod)
                .HasColumnName("paymentmethod")
                .HasConversion<string>();

            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.Tableid).HasColumnName("tableid");
            entity.Property(e => e.Waiterid).HasColumnName("waiterid");

            entity.HasOne(d => d.Table).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Tableid)
                .HasConstraintName("orders_tableid_fkey");

            entity.HasOne(d => d.Waiter).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Waiterid)
                .HasConstraintName("orders_waiterid_fkey");
        });



        modelBuilder.Entity<Orderitem>(entity =>
        {
            entity.HasKey(e => e.Orderitemid).HasName("orderitems_pkey");

            entity.ToTable("orderitems");

            entity.Property(e => e.Orderitemid).HasColumnName("orderitemid");
            entity.Property(e => e.Dishid).HasColumnName("dishid");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Dish).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.Dishid)
                .HasConstraintName("orderitems_dishid_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.Orderid)
                .HasConstraintName("orderitems_orderid_fkey");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Reportid).HasName("reports_pkey");

            entity.ToTable("reports");

            entity.Property(e => e.Reportid).HasColumnName("reportid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Reportdate).HasColumnName("reportdate");
            entity.Property(e => e.Reporttype)
                .HasMaxLength(255)
                .HasColumnName("reporttype");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Shiftid).HasName("shifts_pkey");

            entity.ToTable("shifts");

            entity.Property(e => e.Shiftid).HasColumnName("shiftid");
            entity.Property(e => e.Endtime).HasColumnName("endtime");
            entity.Property(e => e.Shiftdate).HasColumnName("shiftdate");
            entity.Property(e => e.Starttime).HasColumnName("starttime");
        });

        modelBuilder.Entity<Shiftassignment>(entity =>
        {
            entity.HasKey(e => e.Shiftassignmentid).HasName("shiftassignments_pkey");

            entity.ToTable("shiftassignments");

            entity.Property(e => e.Shiftassignmentid).HasColumnName("shiftassignmentid");
            entity.Property(e => e.Shiftid).HasColumnName("shiftid");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Shift).WithMany(p => p.Shiftassignments)
                .HasForeignKey(d => d.Shiftid)
                .HasConstraintName("shiftassignments_shiftid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Shiftassignments)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("shiftassignments_userid_fkey");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Tableid).HasName("tables_pkey");

            entity.ToTable("tables");

            entity.Property(e => e.Tableid).HasColumnName("tableid");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.Tablename)
                .HasMaxLength(255)
                .HasColumnName("tablename");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "users_username_key").IsUnique();

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.Usertypeid).HasColumnName("usertypeid");

            entity.HasOne(d => d.Usertype).WithMany(p => p.Users)
                .HasForeignKey(d => d.Usertypeid)
                .HasConstraintName("users_usertypeid_fkey");
        });

        modelBuilder.Entity<Usertype>(entity =>
        {
            entity.HasKey(e => e.Usertypeid).HasName("usertypes_pkey");

            entity.ToTable("usertypes");

            entity.Property(e => e.Usertypeid).HasColumnName("usertypeid");
            entity.Property(e => e.Usertypename)
                .HasMaxLength(255)
                .HasColumnName("usertypename");
        });

        modelBuilder.Entity<Waiterassignment>(entity =>
        {
            entity.HasKey(e => e.Waiterassignmentid).HasName("waiterassignments_pkey");

            entity.ToTable("waiterassignments");

            entity.Property(e => e.Waiterassignmentid).HasColumnName("waiterassignmentid");
            entity.Property(e => e.Tableid).HasColumnName("tableid");
            entity.Property(e => e.Waiterid).HasColumnName("waiterid");

            entity.HasOne(d => d.Table).WithMany(p => p.Waiterassignments)
                .HasForeignKey(d => d.Tableid)
                .HasConstraintName("waiterassignments_tableid_fkey");

            entity.HasOne(d => d.Waiter).WithMany(p => p.Waiterassignments)
                .HasForeignKey(d => d.Waiterid)
                .HasConstraintName("waiterassignments_waiterid_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
