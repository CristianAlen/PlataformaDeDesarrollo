using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcialTarea.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreUsuario = table.Column<string>(maxLength: 10, nullable: false),
                    Clave = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    IdRecursos = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioIdUsuario = table.Column<int>(nullable: true),
                    idUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.IdRecursos);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    IdDetalles = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<string>(maxLength: 8, nullable: false),
                    Tiempo = table.Column<string>(maxLength: 4, nullable: false),
                    RecursoIdRecursos = table.Column<int>(nullable: true),
                    IdRecurso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.IdDetalles);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoIdRecursos",
                        column: x => x.RecursoIdRecursos,
                        principalTable: "Recurso",
                        principalColumn: "IdRecursos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    IdTareas = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: false),
                    Vencimiento = table.Column<string>(nullable: false),
                    Estimacion = table.Column<string>(nullable: false),
                    ResponsableIdRecursos = table.Column<int>(nullable: true),
                    IdResponsable = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.IdTareas);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_ResponsableIdRecursos",
                        column: x => x.ResponsableIdRecursos,
                        principalTable: "Recurso",
                        principalColumn: "IdRecursos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoIdRecursos",
                table: "Detalle",
                column: "RecursoIdRecursos");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioIdUsuario",
                table: "Recurso",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ResponsableIdRecursos",
                table: "Tarea",
                column: "ResponsableIdRecursos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
