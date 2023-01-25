using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosApi.Migrations
{
    /// <inheritdoc />
    public partial class teste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Acao",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Aventura",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EsporteECorrida",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estrategia",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Jogadores",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RPG",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Simulacao",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Temas",
                table: "TB_GAMES",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acao",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "Aventura",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "EsporteECorrida",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "Estrategia",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "Jogadores",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "RPG",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "Simulacao",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "Temas",
                table: "TB_GAMES");
        }
    }
}
