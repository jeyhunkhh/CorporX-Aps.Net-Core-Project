using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class AdminAccountFirstAddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "FullName", "Password", "Token" },
                values: new object[] { 1, "admin@admin", "admin", "AQAAAAEAACcQAAAAEJ0HhqmpriXF6GMyiXjaj+9M2d2XhaR5MxbJ70aMsU5gxyrtydJopuOFMCqa7rw/pw==", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
