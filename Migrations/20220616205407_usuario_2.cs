using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class usuario_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PermisosUsuario_PermisoUsuarioFK",
                table: "PermisosUsuario",
                column: "PermisoUsuarioFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionUsuario_ConfigUsuarioFK",
                table: "ConfiguracionUsuario",
                column: "ConfigUsuarioFK",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ConfiguracionUsuario_Usuarios_ConfigUsuarioFK",
                table: "ConfiguracionUsuario",
                column: "ConfigUsuarioFK",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermisosUsuario_Usuarios_PermisoUsuarioFK",
                table: "PermisosUsuario",
                column: "PermisoUsuarioFK",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfiguracionUsuario_Usuarios_ConfigUsuarioFK",
                table: "ConfiguracionUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PermisosUsuario_Usuarios_PermisoUsuarioFK",
                table: "PermisosUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PermisosUsuario_PermisoUsuarioFK",
                table: "PermisosUsuario");

            migrationBuilder.DropIndex(
                name: "IX_ConfiguracionUsuario_ConfigUsuarioFK",
                table: "ConfiguracionUsuario");
        }
    }
}
