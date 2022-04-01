using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEPUDO.Infrastructure.Migrations
{
    public partial class Initialize_BD_Sepudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Estrato = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suscriptores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsoId = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoVerificacion = table.Column<int>(type: "int", nullable: false),
                    Sistema = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alcantarillado = table.Column<bool>(type: "bit", nullable: false),
                    Aseo = table.Column<bool>(type: "bit", nullable: false),
                    Atraso = table.Column<int>(type: "int", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManzanaDane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManzanaIgac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManzanaEstratifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bloqueo = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suscriptores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suscriptores_Usos_UsoId",
                        column: x => x.UsoId,
                        principalTable: "Usos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suscriptores_UsoId",
                table: "Suscriptores",
                column: "UsoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suscriptores");

            migrationBuilder.DropTable(
                name: "Usos");
        }
    }
}
