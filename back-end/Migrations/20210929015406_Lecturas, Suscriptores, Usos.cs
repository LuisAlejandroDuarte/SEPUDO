using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class LecturasSuscriptoresUsos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectura_Suscriptor_SuscriptorId",
                table: "Lectura");

            migrationBuilder.DropForeignKey(
                name: "FK_Suscriptor_Uso_UsoId",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "Inquilinato",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "Multiusuario",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "Residencial",
                table: "Suscriptor");

            migrationBuilder.DropColumn(
                name: "Urbano",
                table: "Suscriptor");

            migrationBuilder.AlterColumn<long>(
                name: "UsoId",
                table: "Suscriptor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SuscriptorId",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaLectura",
                table: "Lectura",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "Lectura1",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Lectura2",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Lectura3",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Lectura4",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Lectura5",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Lectura6",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LecturaActual",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LecturaAnterior",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LecturaTemporal",
                table: "Lectura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Consumo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuscriptorId = table.Column<long>(type: "bigint", nullable: false),
                    Consumo1 = table.Column<long>(type: "bigint", nullable: false),
                    Consumo2 = table.Column<long>(type: "bigint", nullable: false),
                    Consumo3 = table.Column<long>(type: "bigint", nullable: false),
                    Consumo4 = table.Column<long>(type: "bigint", nullable: false),
                    Consumo5 = table.Column<long>(type: "bigint", nullable: false),
                    Consumo6 = table.Column<long>(type: "bigint", nullable: false),
                    ConsumoActual = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumo_Suscriptor_SuscriptorId",
                        column: x => x.SuscriptorId,
                        principalTable: "Suscriptor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumo_SuscriptorId",
                table: "Consumo",
                column: "SuscriptorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectura_Suscriptor_SuscriptorId",
                table: "Lectura",
                column: "SuscriptorId",
                principalTable: "Suscriptor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suscriptor_Uso_UsoId",
                table: "Suscriptor",
                column: "UsoId",
                principalTable: "Uso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectura_Suscriptor_SuscriptorId",
                table: "Lectura");

            migrationBuilder.DropForeignKey(
                name: "FK_Suscriptor_Uso_UsoId",
                table: "Suscriptor");

            migrationBuilder.DropTable(
                name: "Consumo");

            migrationBuilder.DropColumn(
                name: "FechaLectura",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "Lectura1",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "Lectura2",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "Lectura3",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "Lectura4",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "Lectura5",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "Lectura6",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "LecturaActual",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "LecturaAnterior",
                table: "Lectura");

            migrationBuilder.DropColumn(
                name: "LecturaTemporal",
                table: "Lectura");

            migrationBuilder.AlterColumn<long>(
                name: "UsoId",
                table: "Suscriptor",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<bool>(
                name: "Inquilinato",
                table: "Suscriptor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Multiusuario",
                table: "Suscriptor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Residencial",
                table: "Suscriptor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Urbano",
                table: "Suscriptor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<long>(
                name: "SuscriptorId",
                table: "Lectura",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectura_Suscriptor_SuscriptorId",
                table: "Lectura",
                column: "SuscriptorId",
                principalTable: "Suscriptor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suscriptor_Uso_UsoId",
                table: "Suscriptor",
                column: "UsoId",
                principalTable: "Uso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
