using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationBE.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreviousChurchExperiance",
                table: "Students",
                newName: "ChurchExperiance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChurchExperiance",
                table: "Students",
                newName: "PreviousChurchExperiance");
        }
    }
}
