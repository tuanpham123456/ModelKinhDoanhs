using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class payment_authorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Approval_code",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avs",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Card_code",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code1",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code2",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code3",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Md5",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Optlock",
                table: "Payment_Authorizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Payment_ID",
                table: "Payment_Authorizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Response_message",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transaction_ID",
                table: "Payment_Authorizations",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approval_code",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Avs",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Card_code",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Code1",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Code2",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Code3",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Md5",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Optlock",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Payment_ID",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Response_message",
                table: "Payment_Authorizations");

            migrationBuilder.DropColumn(
                name: "Transaction_ID",
                table: "Payment_Authorizations");
        }
    }
}
