using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentinfo.Migrations
{
    /// <inheritdoc />
    public partial class studentdbcontextupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentCourses_Students_Id",
                table: "studentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "studentCourses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_studentCourses_Students_StudentId",
                table: "studentCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentCourses_Students_StudentId",
                table: "studentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "studentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses",
                columns: new[] { "Id", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_studentCourses_Students_Id",
                table: "studentCourses",
                column: "Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
