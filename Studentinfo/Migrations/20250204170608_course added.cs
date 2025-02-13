using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentinfo.Migrations
{
    /// <inheritdoc />
    public partial class courseadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "studentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "studentCourses");
        }
    }
}
