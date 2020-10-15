using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class AdminAccountAddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJ0HhqmpriXF6GMyiXjaj+9M2d2XhaR5MxbJ70aMsU5gxyrtydJopuOFMCqa7rw/pw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "+9M2d2XhaR5MxbJ70aMsU5gxyrtydJopuOFMCqa7rw/pw==");
        }
    }
}
