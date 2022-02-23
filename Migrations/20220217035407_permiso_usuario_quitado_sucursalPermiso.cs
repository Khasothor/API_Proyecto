using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class permiso_usuario_quitado_sucursalPermiso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermisoSucursal",
                table: "PermisosUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PermisoSucursal",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
