using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ryan.Migrations
{
    public partial class aboutmodeledited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Quote",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Quote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedByUserId",
                table: "Quote",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Quote",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "AboutMe",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AboutMe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedByUserId",
                table: "AboutMe",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "AboutMe",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "About",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedByUserId",
                table: "About",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "About",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "AboutMe");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AboutMe");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "AboutMe");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "AboutMe");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "About");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "About");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "About");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "About");
        }
    }
}
