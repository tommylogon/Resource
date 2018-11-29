using Microsoft.EntityFrameworkCore.Migrations;

namespace Resource.Migrations
{
    public partial class Postal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Customer",
                newName: "PostalNr");

            migrationBuilder.AddColumn<string>(
                name: "PostalAdress",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalAdress",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "PostalNr",
                table: "Customer",
                newName: "CompanyName");
        }
    }
}
