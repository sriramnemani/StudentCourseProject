using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCurRegistration.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentInfo",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudPassword = table.Column<string>(nullable: true),
                    StudFirstName = table.Column<string>(nullable: false),
                    StudStartDate = table.Column<DateTime>(nullable: false),
                    StudGender = table.Column<int>(nullable: false),
                    StudEmailAdd = table.Column<string>(maxLength: 50, nullable: false),
                    StudAddress = table.Column<string>(nullable: true),
                    StudphNum = table.Column<long>(maxLength: 10, nullable: false),
                    StudEnrollFee = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentID", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseDate = table.Column<DateTime>(nullable: false),
                    CourseName = table.Column<string>(maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCode", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Courses_StudentInfo_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentInfo",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "StudentInfo");
        }
    }
}
