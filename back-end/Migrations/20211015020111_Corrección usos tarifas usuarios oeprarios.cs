using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class Correcciónusostarifasusuariosoeprarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectura_Operario_OperarioId",
                table: "Lectura");

            migrationBuilder.DropTable(
                name: "Operario");

            migrationBuilder.DropColumn(
                name: "CargoFijoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "CargoFijoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ConsumoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ConsumoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "CostoFijoAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "CostoReferenciaAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "CostoReferenciaAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "CostoReferenciaAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "IncrementoAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "IncrementoConsumoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "IncrementoConsumoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "IncrementoFijoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "IncrementoFijoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "InteresMora",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "OtroSubsidio",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "OtroValor",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "PorcentajeContribucionAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "PorcentajeContribucionAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "PorcentajeContribucionAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "PorcentajeFinanaciacion",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "Rango1",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "Rango2",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "Rango3",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "SubsidioAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "SubsidioBasicoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "SubsidioBasicoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "SubsidioFijoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "SubsidioFijoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorBarridoAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorBasicoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorBasicoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorComplementarioAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorComplementarioAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorDisposicionAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorFijoAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorFijoAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorRecaudoAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorRecoleccionAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorSuntuarioAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ValorSuntuarioAlcantarillado",
                table: "Uso");

            migrationBuilder.RenameColumn(
                name: "Verificacion",
                table: "Suscriptor",
                newName: "CodigoVerificacion");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Uso",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "Tarifa",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsoId = table.Column<long>(type: "bigint", nullable: false),
                    ValorCargoFijoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorBasicoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorComplementarioAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorSuntuarioAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoReferenciaCargoFijoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoReferenciaConsumoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioCargoFijoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioBasicoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeContribucionCargofijoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeContribucionConsumoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoCargoFijoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoConsumoAcueducto = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorCargoFijoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorBasicoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorComplementarioAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorSuntuarioAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoReferenciaCargoFijoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CostoReferenciaConsumoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioCargoFijoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioBasicoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeContribucionCargofijoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeContribucionConsumoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoCargoFijoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoConsumoAlcantarillado = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorBarridoAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorRecoleccionAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorDisposicionAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ValorRecaudoAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    SubsidioAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    IncrementoAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeContribucionAseo = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    InteresMora = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    PorcentajeFinanaciacion = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    OtroValor = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    OtroSubsidio = table.Column<decimal>(type: "decimal(10,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarifa_Uso_UsoId",
                        column: x => x.UsoId,
                        principalTable: "Uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarifa_UsoId",
                table: "Tarifa",
                column: "UsoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectura_Usuario_OperarioId",
                table: "Lectura",
                column: "OperarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectura_Usuario_OperarioId",
                table: "Lectura");

            migrationBuilder.DropTable(
                name: "Tarifa");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.RenameColumn(
                name: "CodigoVerificacion",
                table: "Suscriptor",
                newName: "Verificacion");

            migrationBuilder.AlterColumn<long>(
                name: "Codigo",
                table: "Uso",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "CargoFijoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CargoFijoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ConsumoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ConsumoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoFijoAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoReferenciaAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoReferenciaAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoReferenciaAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IncrementoAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IncrementoConsumoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IncrementoConsumoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IncrementoFijoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IncrementoFijoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InteresMora",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtroSubsidio",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtroValor",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeContribucionAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeContribucionAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeContribucionAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeFinanaciacion",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Rango1",
                table: "Uso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rango2",
                table: "Uso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rango3",
                table: "Uso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SubsidioAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubsidioBasicoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubsidioBasicoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubsidioFijoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubsidioFijoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorBarridoAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorBasicoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorBasicoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorComplementarioAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorComplementarioAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDisposicionAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorFijoAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorFijoAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorRecaudoAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorRecoleccionAseo",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorSuntuarioAcueducto",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorSuntuarioAlcantarillado",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Operario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operario", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lectura_Operario_OperarioId",
                table: "Lectura",
                column: "OperarioId",
                principalTable: "Operario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
