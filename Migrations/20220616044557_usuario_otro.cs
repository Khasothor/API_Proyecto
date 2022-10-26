using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class usuario_otro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfiguracionUsuario_Usuarios_Usuario_UsuarioId",
                table: "ConfiguracionUsuario");

            migrationBuilder.DropIndex(
                name: "IX_ConfiguracionUsuario_Usuario_UsuarioId",
                table: "ConfiguracionUsuario");

            migrationBuilder.DropColumn(
                name: "Usuario_UsuarioId",
                table: "ConfiguracionUsuario");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioFK",
                table: "PermisosUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioFK",
                table: "PermisosUsuario");

            migrationBuilder.AddColumn<int>(
                name: "Usuario_UsuarioId",
                table: "ConfiguracionUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionUsuario_Usuario_UsuarioId",
                table: "ConfiguracionUsuario",
                column: "Usuario_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfiguracionUsuario_Usuarios_Usuario_UsuarioId",
                table: "ConfiguracionUsuario",
                column: "Usuario_UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }
    }
}
