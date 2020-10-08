using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class AboutUsMissionTotalDetele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalBusiness",
                table: "AboutUsMissions");

            migrationBuilder.DropColumn(
                name: "TotalCount",
                table: "AboutUsMissions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TotalBusiness",
                table: "AboutUsMissions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TotalCount",
                table: "AboutUsMissions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
