using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class tipoDocInve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destino",
                table: "TipoDocsInv");

            migrationBuilder.RenameColumn(
                name: "Origen",
                table: "TipoDocsInv",
                newName: "AfectaA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AfectaA",
                table: "TipoDocsInv",
                newName: "Origen");

            migrationBuilder.AddColumn<bool>(
                name: "Destino",
                table: "TipoDocsInv",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
