using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza_Restaurant.Migrations
{
    public partial class AddedSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "MenuItems",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "MenuItems");
        }
    }
}
