using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_Grupo_3_Jefferson_Lara.Data.Migrations
{
    public partial class AddFormatosAcosoLaboral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormatosAcosoLaboral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identidad = table.Column<int>(type: "int", nullable: false),
                    CC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCelular = table.Column<int>(type: "int", nullable: false),
                    Dependencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParrafoHechos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prueba = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormatosAcosoLaboral", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormatosAcosoLaboral");
        }
    }
}
