using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessApp.Data.Migrations
{
    public partial class PrimeraMigracionn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idAvance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idSerieAvance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Circuitos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idCircuito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clavecircuito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    series = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ejercicio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRutina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcionDia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCircuito = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesAvances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSerieAvance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    claveSeries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRutina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCircuito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seriesFinalizadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PesoUsado = table.Column<double>(type: "float", nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesAvances", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avances");

            migrationBuilder.DropTable(
                name: "Circuitos");

            migrationBuilder.DropTable(
                name: "Rutinas");

            migrationBuilder.DropTable(
                name: "SeriesAvances");
        }
    }
}
