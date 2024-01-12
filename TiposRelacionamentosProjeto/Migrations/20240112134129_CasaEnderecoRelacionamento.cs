using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiposRelacionamentosProjeto.Migrations
{
    /// <inheritdoc />
    public partial class CasaEnderecoRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CasaId",
                table: "Enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_CasaId",
                table: "Enderecos",
                column: "CasaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Casas_CasaId",
                table: "Enderecos",
                column: "CasaId",
                principalTable: "Casas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Casas_CasaId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_CasaId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "CasaId",
                table: "Enderecos");
        }
    }
}
