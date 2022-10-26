using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class New_Notif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoMovId",
                table: "Notificaciones",
                newName: "SucOrigen");

            migrationBuilder.RenameColumn(
                name: "OrigenId",
                table: "Notificaciones",
                newName: "SucDestino");

            migrationBuilder.RenameColumn(
                name: "DestinoId",
                table: "Notificaciones",
                newName: "ArOrigen");

            migrationBuilder.AddColumn<int>(
                name: "ArDestino",
                table: "Notificaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArDestino",
                table: "Notificaciones");

            migrationBuilder.RenameColumn(
                name: "SucOrigen",
                table: "Notificaciones",
                newName: "TipoMovId");

            migrationBuilder.RenameColumn(
                name: "SucDestino",
                table: "Notificaciones",
                newName: "OrigenId");

            migrationBuilder.RenameColumn(
                name: "ArOrigen",
                table: "Notificaciones",
                newName: "DestinoId");
        }
    }
}
