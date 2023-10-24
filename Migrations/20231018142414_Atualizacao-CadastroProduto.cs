using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteFinal.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoCadastroProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataValidade",
                table: "CadastroProduto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "CadastroProduto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "CadastroProduto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "CadastroProduto",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataValidade",
                table: "CadastroProduto");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "CadastroProduto");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "CadastroProduto");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "CadastroProduto");

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
        }
    }
}
