using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBackend.Migrations
{
    /// <inheritdoc />
    public partial class createusertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_Students_StudentId",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_courses_CourseId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_categories_StudentId",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Chapters",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chapters",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_StudentId",
                table: "categories",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_Students_StudentId",
                table: "categories",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_courses_CourseId",
                table: "Chapters",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
