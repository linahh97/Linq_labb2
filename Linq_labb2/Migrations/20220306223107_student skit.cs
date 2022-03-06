using Microsoft.EntityFrameworkCore.Migrations;

namespace Linq_labb2.Migrations
{
    public partial class studentskit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "TeacherStudents");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "StudentSubjects");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "TeacherStudents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "StudentSubjects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_students_StudentID",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherStudents_students_StudentID",
                table: "TeacherStudents");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "TeacherStudents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "TeacherStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "StudentSubjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
