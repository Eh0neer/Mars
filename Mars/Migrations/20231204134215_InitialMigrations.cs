using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mars.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dishes",
                columns: table => new
                {
                    dishid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dishname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("dishes_pkey", x => x.dishid);
                });

            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    reportid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reportdate = table.Column<DateOnly>(type: "date", nullable: false),
                    reporttype = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("reports_pkey", x => x.reportid);
                });

            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    shiftid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shiftdate = table.Column<DateOnly>(type: "date", nullable: false),
                    starttime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    endtime = table.Column<TimeOnly>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("shifts_pkey", x => x.shiftid);
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    tableid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tablename = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tables_pkey", x => x.tableid);
                });

            migrationBuilder.CreateTable(
                name: "usertypes",
                columns: table => new
                {
                    usertypeid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usertypename = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usertypes_pkey", x => x.usertypeid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    fullname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    usertypeid = table.Column<int>(type: "integer", nullable: true),
                    status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.userid);
                    table.ForeignKey(
                        name: "users_usertypeid_fkey",
                        column: x => x.usertypeid,
                        principalTable: "usertypes",
                        principalColumn: "usertypeid");
                });

            migrationBuilder.CreateTable(
                name: "employeecards",
                columns: table => new
                {
                    employeecardid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userid = table.Column<int>(type: "integer", nullable: true),
                    photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    employmentcontractscan = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("employeecards_pkey", x => x.employeecardid);
                    table.ForeignKey(
                        name: "employeecards_userid_fkey",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    orderdate = table.Column<DateOnly>(type: "date", nullable: false),
                    tableid = table.Column<int>(type: "integer", nullable: true),
                    waiterid = table.Column<int>(type: "integer", nullable: true),
                    status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    paymentmethod = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("orders_pkey", x => x.orderid);
                    table.ForeignKey(
                        name: "orders_tableid_fkey",
                        column: x => x.tableid,
                        principalTable: "tables",
                        principalColumn: "tableid");
                    table.ForeignKey(
                        name: "orders_waiterid_fkey",
                        column: x => x.waiterid,
                        principalTable: "users",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateTable(
                name: "shiftassignments",
                columns: table => new
                {
                    shiftassignmentid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shiftid = table.Column<int>(type: "integer", nullable: true),
                    userid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("shiftassignments_pkey", x => x.shiftassignmentid);
                    table.ForeignKey(
                        name: "shiftassignments_shiftid_fkey",
                        column: x => x.shiftid,
                        principalTable: "shifts",
                        principalColumn: "shiftid");
                    table.ForeignKey(
                        name: "shiftassignments_userid_fkey",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateTable(
                name: "waiterassignments",
                columns: table => new
                {
                    waiterassignmentid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    waiterid = table.Column<int>(type: "integer", nullable: true),
                    tableid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("waiterassignments_pkey", x => x.waiterassignmentid);
                    table.ForeignKey(
                        name: "waiterassignments_tableid_fkey",
                        column: x => x.tableid,
                        principalTable: "tables",
                        principalColumn: "tableid");
                    table.ForeignKey(
                        name: "waiterassignments_waiterid_fkey",
                        column: x => x.waiterid,
                        principalTable: "users",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateTable(
                name: "cashorders",
                columns: table => new
                {
                    cashorderid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    orderid = table.Column<int>(type: "integer", nullable: true),
                    paymentmethod = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cashorders_pkey", x => x.cashorderid);
                    table.ForeignKey(
                        name: "cashorders_orderid_fkey",
                        column: x => x.orderid,
                        principalTable: "orders",
                        principalColumn: "orderid");
                });

            migrationBuilder.CreateTable(
                name: "orderitems",
                columns: table => new
                {
                    orderitemid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    orderid = table.Column<int>(type: "integer", nullable: true),
                    dishid = table.Column<int>(type: "integer", nullable: true),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("orderitems_pkey", x => x.orderitemid);
                    table.ForeignKey(
                        name: "orderitems_dishid_fkey",
                        column: x => x.dishid,
                        principalTable: "dishes",
                        principalColumn: "dishid");
                    table.ForeignKey(
                        name: "orderitems_orderid_fkey",
                        column: x => x.orderid,
                        principalTable: "orders",
                        principalColumn: "orderid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cashorders_orderid",
                table: "cashorders",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_employeecards_userid",
                table: "employeecards",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_orderitems_dishid",
                table: "orderitems",
                column: "dishid");

            migrationBuilder.CreateIndex(
                name: "IX_orderitems_orderid",
                table: "orderitems",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_tableid",
                table: "orders",
                column: "tableid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_waiterid",
                table: "orders",
                column: "waiterid");

            migrationBuilder.CreateIndex(
                name: "IX_shiftassignments_shiftid",
                table: "shiftassignments",
                column: "shiftid");

            migrationBuilder.CreateIndex(
                name: "IX_shiftassignments_userid",
                table: "shiftassignments",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_users_usertypeid",
                table: "users",
                column: "usertypeid");

            migrationBuilder.CreateIndex(
                name: "users_username_key",
                table: "users",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_waiterassignments_tableid",
                table: "waiterassignments",
                column: "tableid");

            migrationBuilder.CreateIndex(
                name: "IX_waiterassignments_waiterid",
                table: "waiterassignments",
                column: "waiterid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cashorders");

            migrationBuilder.DropTable(
                name: "employeecards");

            migrationBuilder.DropTable(
                name: "orderitems");

            migrationBuilder.DropTable(
                name: "reports");

            migrationBuilder.DropTable(
                name: "shiftassignments");

            migrationBuilder.DropTable(
                name: "waiterassignments");

            migrationBuilder.DropTable(
                name: "dishes");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "tables");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "usertypes");
        }
    }
}
