using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Migrations
{
    /// <inheritdoc />
    public partial class CompleteDbSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_SpeciesData_speciesID",
                table: "SpeciesData",
                column: "speciesID");

            migrationBuilder.AddForeignKey(
                name: "FK_SpeciesData_Species_speciesID",
                table: "SpeciesData",
                column: "speciesID",
                principalTable: "Species",
                principalColumn: "speciesID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpeciesData_Species_speciesID",
                table: "SpeciesData");

            migrationBuilder.DropIndex(
                name: "IX_SpeciesData_speciesID",
                table: "SpeciesData");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Users",
                newName: "UserID");
        }
    }
}
