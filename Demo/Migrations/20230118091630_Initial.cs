using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_Emp_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Emp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Emp",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "ABC" });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "EmpId", "Location" },
                values: new object[] { 1, 1, "Pune" });

            migrationBuilder.CreateIndex(
                name: "IX_Offices_EmpId",
                table: "Offices",
                column: "EmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Emp");
        }
    }
}
