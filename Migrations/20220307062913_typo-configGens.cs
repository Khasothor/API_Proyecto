using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class typoconfigGens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GonfigGenId",
                table: "ConfigsGen",
                newName: "configGenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "configGenId",
                table: "ConfigsGen",
                newName: "GonfigGenId");
        }
    }
}
