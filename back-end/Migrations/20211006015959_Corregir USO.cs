using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class CorregirUSO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorFijo",
                table: "Uso",
                newName: "ValorSuntuarioAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "ValorAseo",
                table: "Uso",
                newName: "ValorSuntuarioAcueducto");

            migrationBuilder.RenameColumn(
                name: "Valor3",
                table: "Uso",
                newName: "ValorRecoleccionAseo");

            migrationBuilder.RenameColumn(
                name: "Valor2",
                table: "Uso",
                newName: "ValorRecaudoAseo");

            migrationBuilder.RenameColumn(
                name: "Valor1",
                table: "Uso",
                newName: "ValorFijoAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "SubsidioFijo",
                table: "Uso",
                newName: "ValorFijoAcueducto");

            migrationBuilder.RenameColumn(
                name: "SubsidioConsumo",
                table: "Uso",
                newName: "ValorDisposicionAseo");

            migrationBuilder.RenameColumn(
                name: "SubsidioAlcantarillado",
                table: "Uso",
                newName: "ValorComplementarioAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "PorcentajeFinanciacion",
                table: "Uso",
                newName: "ValorComplementarioAcueducto");

            migrationBuilder.RenameColumn(
                name: "PorcentajeAlcantarillado",
                table: "Uso",
                newName: "ValorBasicoAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "IncrementoFijo",
                table: "Uso",
                newName: "ValorBasicoAcueducto");

            migrationBuilder.RenameColumn(
                name: "IncrementoConsumo",
                table: "Uso",
                newName: "ValorBarridoAseo");

            migrationBuilder.RenameColumn(
                name: "IncrementoAlcantarillado",
                table: "Uso",
                newName: "SubsidioFijoAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "CostoRConsumo",
                table: "Uso",
                newName: "SubsidioFijoAcueducto");

            migrationBuilder.RenameColumn(
                name: "CostoRCFijo",
                table: "Uso",
                newName: "SubsidioBasicoAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "CostoRAseoCasa",
                table: "Uso",
                newName: "SubsidioBasicoAcueducto");

            migrationBuilder.RenameColumn(
                name: "CostoRAseo",
                table: "Uso",
                newName: "PorcentajeFinanaciacion");

            migrationBuilder.RenameColumn(
                name: "Manzana",
                table: "Suscriptor",
                newName: "ManzanaIgac");

            migrationBuilder.AlterColumn<int>(
                name: "Rango1",
                table: "Uso",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,3)");

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

            migrationBuilder.AddColumn<string>(
                name: "ManzanaDane",
                table: "Suscriptor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManzanaEstratifica",
                table: "Suscriptor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Verificacion",
                table: "Suscriptor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "OperarioId",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Operario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectura_OperarioId",
                table: "Lectura",
                column: "OperarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectura_Operario_OperarioId",
                table: "Lectura",
                column: "OperarioId",
                principalTable: "Operario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectura_Operario_OperarioId",
                table: "Lectura");

            migrationBuilder.DropTable(
                name: "Operario");

            migrationBuilder.DropIndex(
                name: "IX_Lectura_OperarioId",
                table: "Lectura");

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
                name: "PorcentajeContribucionAcueducto",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "PorcentajeContribucionAlcantarillado",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "PorcentajeContribucionAseo",
                table: "Uso");

            migrationBuilder.DropColumn(
                name: "ManzanaDane",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "ManzanaEstratifica",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "Verificacion",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "OperarioId",
                table: "Lectura");

            migrationBuilder.RenameColumn(
                name: "ValorSuntuarioAlcantarillado",
                table: "Uso",
                newName: "ValorFijo");

            migrationBuilder.RenameColumn(
                name: "ValorSuntuarioAcueducto",
                table: "Uso",
                newName: "ValorAseo");

            migrationBuilder.RenameColumn(
                name: "ValorRecoleccionAseo",
                table: "Uso",
                newName: "Valor3");

            migrationBuilder.RenameColumn(
                name: "ValorRecaudoAseo",
                table: "Uso",
                newName: "Valor2");

            migrationBuilder.RenameColumn(
                name: "ValorFijoAlcantarillado",
                table: "Uso",
                newName: "Valor1");

            migrationBuilder.RenameColumn(
                name: "ValorFijoAcueducto",
                table: "Uso",
                newName: "SubsidioFijo");

            migrationBuilder.RenameColumn(
                name: "ValorDisposicionAseo",
                table: "Uso",
                newName: "SubsidioConsumo");

            migrationBuilder.RenameColumn(
                name: "ValorComplementarioAlcantarillado",
                table: "Uso",
                newName: "SubsidioAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "ValorComplementarioAcueducto",
                table: "Uso",
                newName: "PorcentajeFinanciacion");

            migrationBuilder.RenameColumn(
                name: "ValorBasicoAlcantarillado",
                table: "Uso",
                newName: "PorcentajeAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "ValorBasicoAcueducto",
                table: "Uso",
                newName: "IncrementoFijo");

            migrationBuilder.RenameColumn(
                name: "ValorBarridoAseo",
                table: "Uso",
                newName: "IncrementoConsumo");

            migrationBuilder.RenameColumn(
                name: "SubsidioFijoAlcantarillado",
                table: "Uso",
                newName: "IncrementoAlcantarillado");

            migrationBuilder.RenameColumn(
                name: "SubsidioFijoAcueducto",
                table: "Uso",
                newName: "CostoRConsumo");

            migrationBuilder.RenameColumn(
                name: "SubsidioBasicoAlcantarillado",
                table: "Uso",
                newName: "CostoRCFijo");

            migrationBuilder.RenameColumn(
                name: "SubsidioBasicoAcueducto",
                table: "Uso",
                newName: "CostoRAseoCasa");

            migrationBuilder.RenameColumn(
                name: "PorcentajeFinanaciacion",
                table: "Uso",
                newName: "CostoRAseo");

            migrationBuilder.RenameColumn(
                name: "ManzanaIgac",
                table: "Suscriptor",
                newName: "Manzana");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rango1",
                table: "Uso",
                type: "decimal(10,3)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
