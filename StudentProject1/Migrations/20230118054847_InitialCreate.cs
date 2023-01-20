using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentProject1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<string>(nullable: true),
                    gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DepartmentId", "Email", "FirstName", "LastName", "gender" },
                values: new object[] { 1, "CS1", "A.a@gmail.com", "A", "a", 0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DepartmentId", "Email", "FirstName", "LastName", "gender" },
                values: new object[] { 2, "CS2", "B.b@gmail.com", "b", "b", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
