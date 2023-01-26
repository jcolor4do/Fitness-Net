using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessApp.Data.Migrations
{
    public partial class PrimeraMigracionassasda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuitos",
                table: "Circuitos");

            migrationBuilder.RenameTable(
                name: "Circuitos",
                newName: "Circuito");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuito",
                table: "Circuito",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuito",
                table: "Circuito");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Circuito",
                newName: "Circuitos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuitos",
                table: "Circuitos",
                column: "Id");
        }
    }
}
