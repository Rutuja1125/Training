using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Emp",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "ABCD" });

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EmpId", "Location" },
                values: new object[] { 2, "Delhi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emp",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EmpId", "Location" },
                values: new object[] { 1, "Pune" });
        }
    }
}
