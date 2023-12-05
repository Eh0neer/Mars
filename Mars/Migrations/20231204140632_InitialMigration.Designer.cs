﻿// <auto-generated />
using System;
using Mars;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mars.Migrations
{
    [DbContext(typeof(MarsDbContext))]
    [Migration("20231204140632_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Mars.Cashorder", b =>
                {
                    b.Property<int>("Cashorderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("cashorderid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Cashorderid"));

                    b.Property<int?>("Orderid")
                        .HasColumnType("integer")
                        .HasColumnName("orderid");

                    b.Property<string>("Paymentmethod")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("paymentmethod");

                    b.HasKey("Cashorderid")
                        .HasName("cashorders_pkey");

                    b.HasIndex("Orderid");

                    b.ToTable("cashorders", (string)null);
                });

            modelBuilder.Entity("Mars.Dish", b =>
                {
                    b.Property<int>("Dishid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("dishid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Dishid"));

                    b.Property<string>("Dishname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("dishname");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("price");

                    b.HasKey("Dishid")
                        .HasName("dishes_pkey");

                    b.ToTable("dishes", (string)null);
                });

            modelBuilder.Entity("Mars.Employeecard", b =>
                {
                    b.Property<int>("Employeecardid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("employeecardid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Employeecardid"));

                    b.Property<byte[]>("Employmentcontractscan")
                        .HasColumnType("bytea")
                        .HasColumnName("employmentcontractscan");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea")
                        .HasColumnName("photo");

                    b.Property<int?>("Userid")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("Employeecardid")
                        .HasName("employeecards_pkey");

                    b.HasIndex("Userid");

                    b.ToTable("employeecards", (string)null);
                });

            modelBuilder.Entity("Mars.Order", b =>
                {
                    b.Property<int>("Orderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("orderid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Orderid"));

                    b.Property<DateOnly>("Orderdate")
                        .HasColumnType("date")
                        .HasColumnName("orderdate");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("paymentmethod");

                    b.Property<int>("Status")
                        .HasMaxLength(255)
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int?>("Tableid")
                        .HasColumnType("integer")
                        .HasColumnName("tableid");

                    b.Property<int?>("Waiterid")
                        .HasColumnType("integer")
                        .HasColumnName("waiterid");

                    b.HasKey("Orderid")
                        .HasName("orders_pkey");

                    b.HasIndex("Tableid");

                    b.HasIndex("Waiterid");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("Mars.Orderitem", b =>
                {
                    b.Property<int>("Orderitemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("orderitemid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Orderitemid"));

                    b.Property<int?>("Dishid")
                        .HasColumnType("integer")
                        .HasColumnName("dishid");

                    b.Property<int?>("Orderid")
                        .HasColumnType("integer")
                        .HasColumnName("orderid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("Orderitemid")
                        .HasName("orderitems_pkey");

                    b.HasIndex("Dishid");

                    b.HasIndex("Orderid");

                    b.ToTable("orderitems", (string)null);
                });

            modelBuilder.Entity("Mars.Report", b =>
                {
                    b.Property<int>("Reportid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("reportid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Reportid"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateOnly>("Reportdate")
                        .HasColumnType("date")
                        .HasColumnName("reportdate");

                    b.Property<string>("Reporttype")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("reporttype");

                    b.HasKey("Reportid")
                        .HasName("reports_pkey");

                    b.ToTable("reports", (string)null);
                });

            modelBuilder.Entity("Mars.Shift", b =>
                {
                    b.Property<int>("Shiftid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("shiftid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Shiftid"));

                    b.Property<TimeOnly>("Endtime")
                        .HasColumnType("time without time zone")
                        .HasColumnName("endtime");

                    b.Property<DateOnly>("Shiftdate")
                        .HasColumnType("date")
                        .HasColumnName("shiftdate");

                    b.Property<TimeOnly>("Starttime")
                        .HasColumnType("time without time zone")
                        .HasColumnName("starttime");

                    b.HasKey("Shiftid")
                        .HasName("shifts_pkey");

                    b.ToTable("shifts", (string)null);
                });

            modelBuilder.Entity("Mars.Shiftassignment", b =>
                {
                    b.Property<int>("Shiftassignmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("shiftassignmentid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Shiftassignmentid"));

                    b.Property<int?>("Shiftid")
                        .HasColumnType("integer")
                        .HasColumnName("shiftid");

                    b.Property<int?>("Userid")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("Shiftassignmentid")
                        .HasName("shiftassignments_pkey");

                    b.HasIndex("Shiftid");

                    b.HasIndex("Userid");

                    b.ToTable("shiftassignments", (string)null);
                });

            modelBuilder.Entity("Mars.Table", b =>
                {
                    b.Property<int>("Tableid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tableid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Tableid"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<string>("Tablename")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("tablename");

                    b.HasKey("Tableid")
                        .HasName("tables_pkey");

                    b.ToTable("tables", (string)null);
                });

            modelBuilder.Entity("Mars.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Userid"));

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("fullname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("status");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("username");

                    b.Property<int?>("Usertypeid")
                        .HasColumnType("integer")
                        .HasColumnName("usertypeid");

                    b.HasKey("Userid")
                        .HasName("users_pkey");

                    b.HasIndex("Usertypeid");

                    b.HasIndex(new[] { "Username" }, "users_username_key")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Mars.Usertype", b =>
                {
                    b.Property<int>("Usertypeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("usertypeid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Usertypeid"));

                    b.Property<string>("Usertypename")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("usertypename");

                    b.HasKey("Usertypeid")
                        .HasName("usertypes_pkey");

                    b.ToTable("usertypes", (string)null);
                });

            modelBuilder.Entity("Mars.Waiterassignment", b =>
                {
                    b.Property<int>("Waiterassignmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("waiterassignmentid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Waiterassignmentid"));

                    b.Property<int?>("Tableid")
                        .HasColumnType("integer")
                        .HasColumnName("tableid");

                    b.Property<int?>("Waiterid")
                        .HasColumnType("integer")
                        .HasColumnName("waiterid");

                    b.HasKey("Waiterassignmentid")
                        .HasName("waiterassignments_pkey");

                    b.HasIndex("Tableid");

                    b.HasIndex("Waiterid");

                    b.ToTable("waiterassignments", (string)null);
                });

            modelBuilder.Entity("Mars.Cashorder", b =>
                {
                    b.HasOne("Mars.Order", "Order")
                        .WithMany("Cashorders")
                        .HasForeignKey("Orderid")
                        .HasConstraintName("cashorders_orderid_fkey");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Mars.Employeecard", b =>
                {
                    b.HasOne("Mars.User", "User")
                        .WithMany("Employeecards")
                        .HasForeignKey("Userid")
                        .HasConstraintName("employeecards_userid_fkey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mars.Order", b =>
                {
                    b.HasOne("Mars.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("Tableid")
                        .HasConstraintName("orders_tableid_fkey");

                    b.HasOne("Mars.User", "Waiter")
                        .WithMany("Orders")
                        .HasForeignKey("Waiterid")
                        .HasConstraintName("orders_waiterid_fkey");

                    b.Navigation("Table");

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("Mars.Orderitem", b =>
                {
                    b.HasOne("Mars.Dish", "Dish")
                        .WithMany("Orderitems")
                        .HasForeignKey("Dishid")
                        .HasConstraintName("orderitems_dishid_fkey");

                    b.HasOne("Mars.Order", "Order")
                        .WithMany("Orderitems")
                        .HasForeignKey("Orderid")
                        .HasConstraintName("orderitems_orderid_fkey");

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Mars.Shiftassignment", b =>
                {
                    b.HasOne("Mars.Shift", "Shift")
                        .WithMany("Shiftassignments")
                        .HasForeignKey("Shiftid")
                        .HasConstraintName("shiftassignments_shiftid_fkey");

                    b.HasOne("Mars.User", "User")
                        .WithMany("Shiftassignments")
                        .HasForeignKey("Userid")
                        .HasConstraintName("shiftassignments_userid_fkey");

                    b.Navigation("Shift");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mars.User", b =>
                {
                    b.HasOne("Mars.Usertype", "Usertype")
                        .WithMany("Users")
                        .HasForeignKey("Usertypeid")
                        .HasConstraintName("users_usertypeid_fkey");

                    b.Navigation("Usertype");
                });

            modelBuilder.Entity("Mars.Waiterassignment", b =>
                {
                    b.HasOne("Mars.Table", "Table")
                        .WithMany("Waiterassignments")
                        .HasForeignKey("Tableid")
                        .HasConstraintName("waiterassignments_tableid_fkey");

                    b.HasOne("Mars.User", "Waiter")
                        .WithMany("Waiterassignments")
                        .HasForeignKey("Waiterid")
                        .HasConstraintName("waiterassignments_waiterid_fkey");

                    b.Navigation("Table");

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("Mars.Dish", b =>
                {
                    b.Navigation("Orderitems");
                });

            modelBuilder.Entity("Mars.Order", b =>
                {
                    b.Navigation("Cashorders");

                    b.Navigation("Orderitems");
                });

            modelBuilder.Entity("Mars.Shift", b =>
                {
                    b.Navigation("Shiftassignments");
                });

            modelBuilder.Entity("Mars.Table", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Waiterassignments");
                });

            modelBuilder.Entity("Mars.User", b =>
                {
                    b.Navigation("Employeecards");

                    b.Navigation("Orders");

                    b.Navigation("Shiftassignments");

                    b.Navigation("Waiterassignments");
                });

            modelBuilder.Entity("Mars.Usertype", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
