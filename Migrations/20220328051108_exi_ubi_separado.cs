using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class exi_ubi_separado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExistenciaJson",
                table: "Existencias",
                newName: "ExisLineJson");

            migrationBuilder.AddColumn<string>(
                name: "ExisAlmaJson",
                table: "Existencias",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExisAlmaJson",
                table: "Existencias");

            migrationBuilder.RenameColumn(
                name: "ExisLineJson",
                table: "Existencias",
                newName: "ExistenciaJson");
        }
    }
}
