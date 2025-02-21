using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Abouts",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "Detail");
        }
    }
}
