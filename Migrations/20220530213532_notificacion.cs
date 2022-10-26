using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class notificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodsAltInv");

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    NotificacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoMovId = table.Column<int>(type: "int", nullable: false),
                    OrigenId = table.Column<int>(type: "int", nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<float>(type: "real", nullable: false),
                    ObjetoJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabla = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.NotificacionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.CreateTable(
                name: "CodsAltInv",
                columns: table => new
                {
                    CodAltInvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodAltFK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodAltInvJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodsAltInv", x => x.CodAltInvId);
                    table.ForeignKey(
                        name: "FK_CodsAltInv_Inventarios_CodAltFK",
                        column: x => x.CodAltFK,
                        principalTable: "Inventarios",
                        principalColumn: "InventarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodsAltInv_CodAltFK",
                table: "CodsAltInv",
                column: "CodAltFK",
                unique: true);
        }
    }
}
