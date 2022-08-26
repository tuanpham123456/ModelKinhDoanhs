using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccess.Migrations
{
    public partial class Payment_authorizations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment_authorizations",
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
                    table.PrimaryKey("PK_Payment_authorizations", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment_authorizations");
        }
    }
}
