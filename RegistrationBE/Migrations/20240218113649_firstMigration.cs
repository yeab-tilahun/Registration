using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationBE.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<int>(type: "integer", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Debr = table.Column<string>(type: "text", nullable: true),
                    HaveRepentFather = table.Column<bool>(type: "boolean", nullable: true),
                    PrefferedLocation = table.Column<string>(type: "text", nullable: true),
                    OwnCar = table.Column<bool>(type: "boolean", nullable: true),
                    CarInfo = table.Column<string>(type: "text", nullable: true),
                    NeedCar = table.Column<bool>(type: "boolean", nullable: true),
                    PreviousChurchExperiance = table.Column<string>(type: "text", nullable: true),
                    LearnedBefore = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
