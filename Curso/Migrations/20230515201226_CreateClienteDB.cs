using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curso.Migrations
{
    /// <inheritdoc />
    public partial class CreateClienteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cuil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroDocuemnto = table.Column<int>(type: "int", nullable: false),
                    esEmpleado = table.Column<bool>(type: "bit", nullable: false),
                    paisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
