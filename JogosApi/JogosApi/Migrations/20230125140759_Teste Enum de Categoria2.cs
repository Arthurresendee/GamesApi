using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosApi.Migrations
{
    /// <inheritdoc />
    public partial class TesteEnumdeCategoria2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria2Id",
                table: "TB_GAMES");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria3Id",
                table: "TB_GAMES");

            migrationBuilder.DropIndex(
                name: "IX_TB_GAMES_EnumCategoria2Id",
                table: "TB_GAMES");

            migrationBuilder.DropIndex(
                name: "IX_TB_GAMES_EnumCategoria3Id",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "EnumCategoria2Id",
                table: "TB_GAMES");

            migrationBuilder.RenameColumn(
                name: "EnumCategoria3Id",
                table: "TB_GAMES",
                newName: "Categoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "TB_GAMES",
                newName: "EnumCategoria3Id");

            migrationBuilder.AddColumn<int>(
                name: "EnumCategoria2Id",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_GAMES_EnumCategoria2Id",
                table: "TB_GAMES",
                column: "EnumCategoria2Id");

            migrationBuilder.CreateIndex(
                name: "IX_TB_GAMES_EnumCategoria3Id",
                table: "TB_GAMES",
                column: "EnumCategoria3Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria2Id",
                table: "TB_GAMES",
                column: "EnumCategoria2Id",
                principalTable: "EnumCategoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria3Id",
                table: "TB_GAMES",
                column: "EnumCategoria3Id",
                principalTable: "EnumCategoria",
                principalColumn: "Id");
        }
    }
}
