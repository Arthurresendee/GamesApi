using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosApi.Migrations
{
    /// <inheritdoc />
    public partial class Trocandonomedoscamposeadicionandoenumsdecategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria1Id",
                table: "TB_GAMES");

            migrationBuilder.DropTable(
                name: "EnumCategoria");

            migrationBuilder.DropIndex(
                name: "IX_TB_GAMES_EnumCategoria1Id",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "EnumCategoria1Id",
                table: "TB_GAMES");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "TB_GAMES",
                newName: "Criador");

            migrationBuilder.AddColumn<int>(
                name: "Acao",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aventura",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EsporteECorrida",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Estrategia",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Jogadores",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPG",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Simulacao",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temas",
                table: "TB_GAMES",
                type: "int",
                nullable: false,
                defaultValue: 0);
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

            migrationBuilder.RenameColumn(
                name: "Criador",
                table: "TB_GAMES",
                newName: "CriadoPor");

            migrationBuilder.AddColumn<int>(
                name: "EnumCategoria1Id",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EnumCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumCategoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_GAMES_EnumCategoria1Id",
                table: "TB_GAMES",
                column: "EnumCategoria1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria1Id",
                table: "TB_GAMES",
                column: "EnumCategoria1Id",
                principalTable: "EnumCategoria",
                principalColumn: "Id");
        }
    }
}
