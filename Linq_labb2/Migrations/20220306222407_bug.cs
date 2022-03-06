using Microsoft.EntityFrameworkCore.Migrations;

namespace Linq_labb2.Migrations
{
    public partial class bug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "students",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "StudentName",
                table: "students",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "StudentName",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
