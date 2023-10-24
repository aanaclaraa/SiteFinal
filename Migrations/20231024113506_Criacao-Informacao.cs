using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteFinal.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInformacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OquSao",
                table: "Informacao",
                newName: "OqueSao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OqueSao",
                table: "Informacao",
                newName: "OquSao");
        }
    }
}
