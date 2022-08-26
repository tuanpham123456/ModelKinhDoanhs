using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccess.Migrations
{
    public partial class Payments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    User_ID = table.Column<string>(type: "text", nullable: true),
                    attempt = table.Column<string>(type: "text", nullable: true),
                    result_ID = table.Column<string>(type: "text", nullable: true),
                    amount = table.Column<double>(type: "double", nullable: false),
                    Payment_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Method_ID = table.Column<string>(type: "text", nullable: true),
                    Credit_Car_ID = table.Column<string>(type: "text", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Is_Refund = table.Column<int>(type: "int", nullable: false),
                    Is_PreAuth = table.Column<int>(type: "int", nullable: false),
                    Payment_ID = table.Column<int>(type: "int", nullable: false),
                    Currency_ID = table.Column<int>(type: "int", nullable: false),
                    Payout_ID = table.Column<int>(type: "int", nullable: false),
                    Ach_ID = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<double>(type: "double", nullable: false),
                    Optlock = table.Column<int>(type: "int", nullable: false),
                    Payment_Period = table.Column<int>(type: "int", nullable: false),
                    Payment_Notes = table.Column<string>(type: "text", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
