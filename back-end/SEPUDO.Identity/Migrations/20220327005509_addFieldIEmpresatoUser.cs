using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEPUDO.Identity.Migrations
{
    public partial class addFieldIEmpresatoUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdEmpresa",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b5414f-4f66-40e3-a400-bed02e9e1b30",
                column: "ConcurrencyStamp",
                value: "57c18691-7f8a-4e10-bf2e-e13db70353f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67fa1d4a-f729-44bc-ae9a-62d5510a338c",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8dd40d4c-620f-4c28-80f2-39856323f64b", "Operario", "OPERARIO" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb249f50-ac6d-11ec-b909-0242ac120002", "407c8032-a992-4709-ba8f-747c209cf2e5", "Usuario", "Usuario" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e684fdd-435e-4729-8d9e-962983e62e12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f82d112-86bc-40f2-a002-5fc4e8f08827", "AQAAAAEAACcQAAAAEFGGz/nH6toBa9l4FSoA9WAScSC7/M9KyRUhyH6rf0Rg3ym53nDorQqdwoEn5PtQvg==", "184ca129-6485-4d1f-a4ff-bf04727dc7b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db801ec6-eb50-413e-b511-ee2aaf6006f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5847212-79c9-4bd4-bb28-dcf090a1a8a2", "AQAAAAEAACcQAAAAEBimQzkttweAoU7Xcpm+OKMN0NZg7emZdaqmjtLBt2mJhvEnfVuxipk6WfFI3+goCw==", "abee8589-ddd2-4ff4-b7cf-db1b9cbc446a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb249f50-ac6d-11ec-b909-0242ac120002");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b5414f-4f66-40e3-a400-bed02e9e1b30",
                column: "ConcurrencyStamp",
                value: "485ab99c-1b5d-4133-994a-dcbba201a407");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67fa1d4a-f729-44bc-ae9a-62d5510a338c",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "116eab0b-6fd7-4d3d-8fba-b351e759658d", "Operator", "OPERATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e684fdd-435e-4729-8d9e-962983e62e12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1aa9620-55f7-468f-88a1-7e786010088d", "AQAAAAEAACcQAAAAEGvk3Msc3XUvbgXECvFSQR+XWZbn6AXLC4ZSx9XhBJNckH4AdaOqYJnJwmcOIcO0vw==", "0a865ac6-c9b0-438e-974d-4a33c2260d3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db801ec6-eb50-413e-b511-ee2aaf6006f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30316759-c594-420b-9ac2-390ae7a833a0", "AQAAAAEAACcQAAAAEAD/HiieIN4w2KFPSIOPdEbg/7iZN6Sk61/IV+JNLxjTZClRNsW8G6Xc1+q+FcvHEQ==", "3b68bb62-467f-45df-8bb7-f4e321835b68" });
        }
    }
}
