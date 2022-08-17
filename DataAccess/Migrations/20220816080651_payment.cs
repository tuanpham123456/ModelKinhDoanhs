using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ach_ID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Payments",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Credit_Car_ID",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Currency_ID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Is_PreAuth",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Is_Refund",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Method_ID",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Optlock",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Payment_Date",
                table: "Payments",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Payment_ID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Payment_Notes",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Payment_Period",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Payout_ID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "User_ID",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "Payments",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "attempt",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "result_ID",
                table: "Payments",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ach_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Credit_Car_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Currency_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Is_PreAuth",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Is_Refund",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Method_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Optlock",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payment_Date",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payment_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payment_Notes",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payment_Period",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payout_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "User_ID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "attempt",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "result_ID",
                table: "Payments");
        }
    }
}
