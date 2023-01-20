using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "EmpId", "Location" },
                values: new object[] { 2, 1, "Pune" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
