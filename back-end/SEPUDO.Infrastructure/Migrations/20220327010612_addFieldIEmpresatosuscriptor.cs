using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEPUDO.Infrastructure.Migrations
{
    public partial class addFieldIEmpresatosuscriptor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdEmprsa",
                table: "Suscriptores",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmprsa",
                table: "Suscriptores");
        }
    }
}
