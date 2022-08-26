using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccess.Migrations
{
    public partial class Payment_vnps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment_vnps",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    vnp_Version = table.Column<string>(type: "text", nullable: true),
                    vnp_Command = table.Column<string>(type: "text", nullable: true),
                    vnp_TmnCode = table.Column<string>(type: "text", nullable: true),
                    vnp_Amount = table.Column<int>(type: "int", nullable: false),
                    vnp_BankCode = table.Column<string>(type: "text", nullable: true),
                    vnp_CurrCode = table.Column<string>(type: "text", nullable: true),
                    vnp_IpAddr = table.Column<string>(type: "text", nullable: true),
                    vnp_Locale = table.Column<string>(type: "text", nullable: true),
                    vnp_OrderInfo = table.Column<string>(type: "text", nullable: true),
                    vnp_OrderType = table.Column<string>(type: "text", nullable: true),
                    vnp_ReturnUrl = table.Column<string>(type: "text", nullable: true),
                    vnp_TxnRef = table.Column<string>(type: "text", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_vnps", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment_vnps");
        }
    }
}
