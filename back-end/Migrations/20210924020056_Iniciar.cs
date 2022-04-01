using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class Iniciar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uso",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estrato = table.Column<int>(type: "int", nullable: false),
                    IncrementoFijo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoConsumo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    InteresMora = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeFinanciacion = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorFijo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    OtroValor = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioFijo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioConsumo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    OtroSubsidio = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Rango1 = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Rango2 = table.Column<int>(type: "int", nullable: false),
                    Rango3 = table.Column<int>(type: "int", nullable: false),
                    Valor1 = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Valor2 = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Valor3 = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoRCFijo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoRConsumo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoRAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoRAseoCasa = table.Column<decimal>(type: "decimal(10,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suscriptor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsoId = table.Column<long>(type: "bigint", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sistema = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alcantarillado = table.Column<bool>(type: "bit", nullable: false),
                    Aseo = table.Column<bool>(type: "bit", nullable: false),
                    Atraso = table.Column<int>(type: "int", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manzana = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Multiusuario = table.Column<bool>(type: "bit", nullable: false),
                    Inquilinato = table.Column<bool>(type: "bit", nullable: false),
                    Residencial = table.Column<bool>(type: "bit", nullable: false),
                    Urbano = table.Column<bool>(type: "bit", nullable: false),
                    Bloqueo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suscriptor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suscriptor_Uso_UsoId",
                        column: x => x.UsoId,
                        principalTable: "Uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lectura",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuscriptorId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectura_Suscriptor_SuscriptorId",
                        column: x => x.SuscriptorId,
                        principalTable: "Suscriptor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectura_SuscriptorId",
                table: "Lectura",
                column: "SuscriptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Suscriptor_UsoId",
                table: "Suscriptor",
                column: "UsoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lectura");

            migrationBuilder.DropTable(
                name: "Suscriptor");

            migrationBuilder.DropTable(
                name: "Uso");
        }
    }
}
