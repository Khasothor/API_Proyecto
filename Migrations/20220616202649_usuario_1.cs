using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class usuario_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioFK",
                table: "PermisosUsuario",
                newName: "PermisoUsuarioFK");

            migrationBuilder.RenameColumn(
                name: "UsuarioFK",
                table: "ConfiguracionUsuario",
                newName: "ConfigUsuarioFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PermisoUsuarioFK",
                table: "PermisosUsuario",
                newName: "UsuarioFK");

            migrationBuilder.RenameColumn(
                name: "ConfigUsuarioFK",
                table: "ConfiguracionUsuario",
                newName: "UsuarioFK");
        }
    }
}
