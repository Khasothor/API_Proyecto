using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class permiso_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Almacen",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaveProd",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaveServ",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clientes",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfigGen",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntiOrgCont",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntiOrgFact",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Entrada",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Existencia",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InveProv",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inventario",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proveedores",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Salida",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shortcut",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sucursal",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDocInv",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniMedDesc",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniMedFact",
                table: "PermisosUsuario",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Almacen",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "ClaveProd",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "ClaveServ",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Clientes",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "ConfigGen",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "EntiOrgCont",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "EntiOrgFact",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "InveProv",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Inventario",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Proveedores",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Ruta",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Salida",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Shortcut",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "Sucursal",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "TipoDocInv",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "UniMedDesc",
                table: "PermisosUsuario");

            migrationBuilder.DropColumn(
                name: "UniMedFact",
                table: "PermisosUsuario");
        }
    }
}
