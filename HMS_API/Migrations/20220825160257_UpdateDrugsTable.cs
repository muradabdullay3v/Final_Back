using Microsoft.EntityFrameworkCore.Migrations;

namespace HMS_API.Migrations
{
    public partial class UpdateDrugsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExpirationTime",
                table: "Drugs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductionTime",
                table: "Drugs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationTime",
                table: "Drugs");

            migrationBuilder.DropColumn(
                name: "ProductionTime",
                table: "Drugs");
        }
    }
}
