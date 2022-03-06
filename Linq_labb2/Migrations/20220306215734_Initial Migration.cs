using Microsoft.EntityFrameworkCore.Migrations;

namespace Linq_labb2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    GradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    SubjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    GradeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_students_grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    TeacherSubID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherID = table.Column<int>(nullable: false),
                    SubjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => x.TeacherSubID);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    StudentSubID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => x.StudentSubID);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherStudents",
                columns: table => new
                {
                    TeachStudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherStudents", x => x.TeachStudentID);
                    table.ForeignKey(
                        name: "FK_TeacherStudents_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherStudents_teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_GradeID",
                table: "students",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentID",
                table: "StudentSubjects",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectID",
                table: "StudentSubjects",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherStudents_StudentID",
                table: "TeacherStudents",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherStudents_TeacherID",
                table: "TeacherStudents",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_SubjectID",
                table: "TeacherSubjects",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_TeacherID",
                table: "TeacherSubjects",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "TeacherStudents");

            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "grades");
        }
    }
}
