using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen1_SistemasdeInformacion.Data.Migrations
{
    public partial class Modelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoCodigo = table.Column<int>(type: "int", nullable: false),
                    EmpleadoApellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpleadoNombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpleadoApodo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmpleadoDireccion = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    EmpleadoCodigoPostal = table.Column<int>(type: "int", nullable: false),
                    EmpleadoTelefono = table.Column<int>(type: "int", nullable: false),
                    EmpleadoCelular = table.Column<int>(type: "int", nullable: false),
                    EmpleadoFax = table.Column<int>(type: "int", nullable: false),
                    EmpleadoEmail = table.Column<int>(type: "int", nullable: false),
                    EmpleadoObservaciones = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
