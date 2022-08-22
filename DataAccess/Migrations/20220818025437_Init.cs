using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ivoices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ivoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    FacebookId = table.Column<string>(type: "text", nullable: true),
                    FacebookAvatarUrl = table.Column<string>(type: "text", nullable: true),
                    IsActived = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Authorizations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Payment_ID = table.Column<int>(type: "int", nullable: false),
                    Processor = table.Column<string>(type: "text", nullable: true),
                    Code1 = table.Column<string>(type: "text", nullable: true),
                    Code2 = table.Column<string>(type: "text", nullable: true),
                    Code3 = table.Column<string>(type: "text", nullable: true),
                    Approval_code = table.Column<string>(type: "text", nullable: true),
                    Avs = table.Column<string>(type: "text", nullable: true),
                    Transaction_ID = table.Column<string>(type: "text", nullable: true),
                    Md5 = table.Column<string>(type: "text", nullable: true),
                    Card_code = table.Column<string>(type: "text", nullable: true),
                    Response_message = table.Column<string>(type: "text", nullable: true),
                    Optlock = table.Column<int>(type: "int", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Authorizations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payment_info_cheque",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Paymet_ID = table.Column<int>(type: "int", nullable: false),
                    Bank = table.Column<string>(type: "text", nullable: true),
                    Cheque_number = table.Column<string>(type: "text", nullable: true),
                    Cheque_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Optlock = table.Column<int>(type: "int", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_info_cheque", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Invoices",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Payment_ID = table.Column<int>(type: "int", nullable: false),
                    Invoice_ID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    Optlock = table.Column<int>(type: "int", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Invoices", x => x.ID);
                });

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
                name: "Ivoices");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Payment_Authorizations");

            migrationBuilder.DropTable(
                name: "Payment_info_cheque");

            migrationBuilder.DropTable(
                name: "Payment_Invoices");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
