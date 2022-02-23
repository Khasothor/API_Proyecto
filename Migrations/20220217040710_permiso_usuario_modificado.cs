using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class permiso_usuario_modificado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "PermisosUsuario");

            migrationBuilder.RenameColumn(
                name: "Salida",
                table: "PermisosUsuario",
                newName: "Ubicacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ubicacion",
                table: "PermisosUsuario",
                newName: "Salida");

            migrationBuilder.AddColumn<string>(
                name: "Entrada",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
