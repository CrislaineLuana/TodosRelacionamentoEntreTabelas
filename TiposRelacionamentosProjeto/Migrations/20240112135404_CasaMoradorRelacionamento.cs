using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiposRelacionamentosProjeto.Migrations
{
    /// <inheritdoc />
    public partial class CasaMoradorRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CasaModelMoradorModel",
                columns: table => new
                {
                    CasasId = table.Column<int>(type: "int", nullable: false),
                    MoradoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasaModelMoradorModel", x => new { x.CasasId, x.MoradoresId });
                    table.ForeignKey(
                        name: "FK_CasaModelMoradorModel_Casas_CasasId",
                        column: x => x.CasasId,
                        principalTable: "Casas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CasaModelMoradorModel_Moradores_MoradoresId",
                        column: x => x.MoradoresId,
                        principalTable: "Moradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CasaModelMoradorModel_MoradoresId",
                table: "CasaModelMoradorModel",
                column: "MoradoresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasaModelMoradorModel");
        }
    }
}
