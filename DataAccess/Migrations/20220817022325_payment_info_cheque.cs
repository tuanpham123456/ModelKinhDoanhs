using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class payment_info_cheque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "Payment_info_cheque",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Cheque_date",
                table: "Payment_info_cheque",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Cheque_number",
                table: "Payment_info_cheque",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Optlock",
                table: "Payment_info_cheque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Paymet_ID",
                table: "Payment_info_cheque",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Payment_info_cheque");

            migrationBuilder.DropColumn(
                name: "Cheque_date",
                table: "Payment_info_cheque");

            migrationBuilder.DropColumn(
                name: "Cheque_number",
                table: "Payment_info_cheque");

            migrationBuilder.DropColumn(
                name: "Optlock",
                table: "Payment_info_cheque");

            migrationBuilder.DropColumn(
                name: "Paymet_ID",
                table: "Payment_info_cheque");
        }
    }
}
