using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteFinal.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoSiteFinal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaProduto");

            migrationBuilder.DropTable(
                name: "Informacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaProduto",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProduto", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Informacao",
                columns: table => new
                {
                    Id_Informacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OqueSao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaberMais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informacao", x => x.Id_Informacao);
                });
        }
    }
}
