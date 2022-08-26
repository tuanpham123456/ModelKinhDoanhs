using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class payment_invoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Payment_Invoices",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Invoice_ID",
                table: "Payment_Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Optlock",
                table: "Payment_Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Payment_ID",
                table: "Payment_Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Payment_Invoices");

            migrationBuilder.DropColumn(
                name: "Invoice_ID",
                table: "Payment_Invoices");

            migrationBuilder.DropColumn(
                name: "Optlock",
                table: "Payment_Invoices");

            migrationBuilder.DropColumn(
                name: "Payment_ID",
                table: "Payment_Invoices");
        }
    }
}
