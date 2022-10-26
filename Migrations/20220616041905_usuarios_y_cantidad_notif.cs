using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class usuarios_y_cantidad_notif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatoUsuarioId",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Notificaciones");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioFK",
                table: "ConfiguracionUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usuario_UsuarioId",
                table: "ConfiguracionUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoUsuario = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CorreoE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UltSesionIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltSesionFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_EntiOrgsCont_EntiOrgContId",
                        column: x => x.EntiOrgContId,
                        principalTable: "EntiOrgsCont",
                        principalColumn: "EntiOrgContId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionUsuario_Usuario_UsuarioId",
                table: "ConfiguracionUsuario",
                column: "Usuario_UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EntiOrgContId",
                table: "Usuarios",
                column: "EntiOrgContId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfiguracionUsuario_Usuarios_Usuario_UsuarioId",
                table: "ConfiguracionUsuario",
                column: "Usuario_UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfiguracionUsuario_Usuarios_Usuario_UsuarioId",
                table: "ConfiguracionUsuario");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_ConfiguracionUsuario_Usuario_UsuarioId",
                table: "ConfiguracionUsuario");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioFK",
                table: "ConfiguracionUsuario");

            migrationBuilder.DropColumn(
                name: "Usuario_UsuarioId",
                table: "ConfiguracionUsuario");

            migrationBuilder.AddColumn<int>(
                name: "DatoUsuarioId",
                table: "PermisosUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Cantidad",
                table: "Notificaciones",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
