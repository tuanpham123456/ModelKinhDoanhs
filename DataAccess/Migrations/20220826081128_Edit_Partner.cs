using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Edit_Partner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActived",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FacebookAvatarUrl",
                table: "Partners",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookId",
                table: "Partners",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActived",
                table: "Partners",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_login",
                table: "Partners",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "status_id",
                table: "Partners",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActived",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FacebookAvatarUrl",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "FacebookId",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "IsActived",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "last_login",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "status_id",
                table: "Partners");
        }
    }
}
