using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosApi.Migrations
{
    /// <inheritdoc />
    public partial class TesteEnumdeCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "TB_GAMES",
                newName: "DataLancamento");

            migrationBuilder.RenameColumn(
                name: "Platform",
                table: "TB_GAMES",
                newName: "Proprietario");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "TB_GAMES",
                newName: "Plataforma");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TB_GAMES",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TB_GAMES",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "CreatoBy",
                table: "TB_GAMES",
                newName: "CriadoPor");

            migrationBuilder.AddColumn<int>(
                name: "EnumCategoria1Id",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnumCategoria2Id",
                table: "TB_GAMES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnumCategoria3Id",
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

            migrationBuilder.CreateIndex(
                name: "IX_TB_GAMES_EnumCategoria2Id",
                table: "TB_GAMES",
                column: "EnumCategoria2Id");

            migrationBuilder.CreateIndex(
                name: "IX_TB_GAMES_EnumCategoria3Id",
                table: "TB_GAMES",
                column: "EnumCategoria3Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria1Id",
                table: "TB_GAMES",
                column: "EnumCategoria1Id",
                principalTable: "EnumCategoria",
                principalColumn: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria1Id",
                table: "TB_GAMES");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria2Id",
                table: "TB_GAMES");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_GAMES_EnumCategoria_EnumCategoria3Id",
                table: "TB_GAMES");

            migrationBuilder.DropTable(
                name: "EnumCategoria");

            migrationBuilder.DropIndex(
                name: "IX_TB_GAMES_EnumCategoria1Id",
                table: "TB_GAMES");

            migrationBuilder.DropIndex(
                name: "IX_TB_GAMES_EnumCategoria2Id",
                table: "TB_GAMES");

            migrationBuilder.DropIndex(
                name: "IX_TB_GAMES_EnumCategoria3Id",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "EnumCategoria1Id",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "EnumCategoria2Id",
                table: "TB_GAMES");

            migrationBuilder.DropColumn(
                name: "EnumCategoria3Id",
                table: "TB_GAMES");

            migrationBuilder.RenameColumn(
                name: "Proprietario",
                table: "TB_GAMES",
                newName: "Platform");

            migrationBuilder.RenameColumn(
                name: "Plataforma",
                table: "TB_GAMES",
                newName: "Owner");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TB_GAMES",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_GAMES",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DataLancamento",
                table: "TB_GAMES",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "TB_GAMES",
                newName: "CreatoBy");
        }
    }
}
