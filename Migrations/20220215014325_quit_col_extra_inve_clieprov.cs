using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class quit_col_extra_inve_clieprov : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatosXtra",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "Sucursales",
                table: "ClieProvs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatosXtra",
                table: "Inventarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sucursales",
                table: "ClieProvs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
