using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class mas_cambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradasSalidas");

            migrationBuilder.DropTable(
                name: "HistoriaEntradaSalidas");

            migrationBuilder.DropIndex(
                name: "IX_TipoDocsInv_EntiOrgContId",
                table: "TipoDocsInv");

            migrationBuilder.RenameColumn(
                name: "TipoDocInvJson",
                table: "TipoDocsInv",
                newName: "Descripcion");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "TipoDocsInv",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Destino",
                table: "TipoDocsInv",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "TipoDocsInv",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Origen",
                table: "TipoDocsInv",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "TipoDocsInv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TipoDocsInv_EntiOrgContId",
                table: "TipoDocsInv",
                column: "EntiOrgContId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TipoDocsInv_EntiOrgContId",
                table: "TipoDocsInv");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "TipoDocsInv");

            migrationBuilder.DropColumn(
                name: "Destino",
                table: "TipoDocsInv");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "TipoDocsInv");

            migrationBuilder.DropColumn(
                name: "Origen",
                table: "TipoDocsInv");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "TipoDocsInv");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "TipoDocsInv",
                newName: "TipoDocInvJson");

            migrationBuilder.CreateTable(
                name: "EntradasSalidas",
                columns: table => new
                {
                    EntradaSalidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlmaRutaId = table.Column<int>(type: "int", nullable: false),
                    ClieProvId = table.Column<int>(type: "int", nullable: false),
                    EntradaSalidaJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Folio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    TipoDocInv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasSalidas", x => x.EntradaSalidaId);
                    table.ForeignKey(
                        name: "FK_EntradasSalidas_EntiOrgsCont_EntiOrgContId",
                        column: x => x.EntiOrgContId,
                        principalTable: "EntiOrgsCont",
                        principalColumn: "EntiOrgContId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaEntradaSalidas",
                columns: table => new
                {
                    HistoriaEntradaSalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntiOrgCont = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HistoriaEntradaSalidaJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaEntradaSalidas", x => x.HistoriaEntradaSalidaId);
                    table.ForeignKey(
                        name: "FK_HistoriaEntradaSalidas_EntiOrgsCont_EntiOrgContId",
                        column: x => x.EntiOrgContId,
                        principalTable: "EntiOrgsCont",
                        principalColumn: "EntiOrgContId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoDocsInv_EntiOrgContId",
                table: "TipoDocsInv",
                column: "EntiOrgContId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntradasSalidas_EntiOrgContId",
                table: "EntradasSalidas",
                column: "EntiOrgContId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaEntradaSalidas_EntiOrgContId",
                table: "HistoriaEntradaSalidas",
                column: "EntiOrgContId");
        }
    }
}
