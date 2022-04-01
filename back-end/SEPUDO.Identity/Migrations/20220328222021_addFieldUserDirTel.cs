using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEPUDO.Identity.Migrations
{
    public partial class addFieldUserDirTel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b5414f-4f66-40e3-a400-bed02e9e1b30",
                column: "ConcurrencyStamp",
                value: "20cb89c4-0eb2-4dbb-a57a-9816af277b68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67fa1d4a-f729-44bc-ae9a-62d5510a338c",
                column: "ConcurrencyStamp",
                value: "8474da28-4c15-46db-8723-2a35e38fa570");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb249f50-ac6d-11ec-b909-0242ac120002",
                column: "ConcurrencyStamp",
                value: "a1536f0d-a49d-44bf-9640-2861a805b150");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e684fdd-435e-4729-8d9e-962983e62e12",
                columns: new[] { "ConcurrencyStamp", "Direccion", "PasswordHash", "SecurityStamp", "Telefono" },
                values: new object[] { "a4e9b437-dfbf-4f80-9a48-a661c2220e4c", "", "AQAAAAEAACcQAAAAEAPRj3j8B6rMUVmiSMm87kpof7lvr24yTvrEvX4VaMocdWtrWPgLP6l3DgBMgxShug==", "34281753-e8fd-4dec-b32c-d446295455f2", "" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db801ec6-eb50-413e-b511-ee2aaf6006f1",
                columns: new[] { "ConcurrencyStamp", "Direccion", "PasswordHash", "SecurityStamp", "Telefono" },
                values: new object[] { "128c0898-b175-400b-948a-730a0259f412", "", "AQAAAAEAACcQAAAAEPJsbA0iBSm9n3/xPpzXawbLzxIllChmdHzFlzQwdn7hMhrUk90vt9koVIONqP+CPg==", "40b9dca6-26db-47dc-a67d-5f18e93754b9", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "AspNetUsers");

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
                column: "ConcurrencyStamp",
                value: "8dd40d4c-620f-4c28-80f2-39856323f64b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb249f50-ac6d-11ec-b909-0242ac120002",
                column: "ConcurrencyStamp",
                value: "407c8032-a992-4709-ba8f-747c209cf2e5");

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
    }
}
