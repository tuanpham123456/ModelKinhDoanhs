using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class @virtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MemberID",
                table: "Payments",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MemberID",
                table: "Payments",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Members_MemberID",
                table: "Payments",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Members_MemberID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_MemberID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Payments");
        }
    }
}
