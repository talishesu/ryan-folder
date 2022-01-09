using Microsoft.EntityFrameworkCore.Migrations;

namespace ryan.Migrations
{
    public partial class ClientSTitleColDELETED : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
