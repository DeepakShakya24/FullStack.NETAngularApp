using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace angularbackend.Migrations
{
    /// <inheritdoc />
    public partial class fixcolumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AngularEmployee",
                keyColumn: "id",
                keyValue: "1d155d12-dcde-4a97-9f38-c60de802c75b");

            migrationBuilder.DeleteData(
                table: "AngularEmployee",
                keyColumn: "id",
                keyValue: "e2fb4ab6-9815-4fca-8e6f-f42558ec32fe");

            migrationBuilder.DeleteData(
                table: "AngularEmployee",
                keyColumn: "id",
                keyValue: "f181f417-0650-4a1c-ac16-3027ad0696bb");

            migrationBuilder.RenameColumn(
                name: "departmnet",
                table: "AngularEmployee",
                newName: "department");

            migrationBuilder.InsertData(
                table: "AngularEmployee",
                columns: new[] { "id", "department", "email", "firstName", "lastName" },
                values: new object[,]
                {
                    { "288270b6-9b1b-4481-88ef-de68be2f5c6b", "IT", "d.sha@acc.com", "Deepak", "Shakya" },
                    { "5191f053-b17b-426a-8a37-5451128b4362", "Writer", "richa.dubey@acc.com", "Richa", "Dubey" },
                    { "7795a5d4-21a7-456a-a01a-638f98bf9f82", "BDE", "shanal.tripathu@acc.com", "Shanal", "Tripathi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AngularEmployee",
                keyColumn: "id",
                keyValue: "288270b6-9b1b-4481-88ef-de68be2f5c6b");

            migrationBuilder.DeleteData(
                table: "AngularEmployee",
                keyColumn: "id",
                keyValue: "5191f053-b17b-426a-8a37-5451128b4362");

            migrationBuilder.DeleteData(
                table: "AngularEmployee",
                keyColumn: "id",
                keyValue: "7795a5d4-21a7-456a-a01a-638f98bf9f82");

            migrationBuilder.RenameColumn(
                name: "department",
                table: "AngularEmployee",
                newName: "departmnet");

            migrationBuilder.InsertData(
                table: "AngularEmployee",
                columns: new[] { "id", "departmnet", "email", "firstName", "lastName" },
                values: new object[,]
                {
                    { "1d155d12-dcde-4a97-9f38-c60de802c75b", "Writer", "richa.dubey@acc.com", "Richa", "Dubey" },
                    { "e2fb4ab6-9815-4fca-8e6f-f42558ec32fe", "IT", "d.sha@acc.com", "Deepak", "Shakya" },
                    { "f181f417-0650-4a1c-ac16-3027ad0696bb", "BDE", "shanal.tripathu@acc.com", "Shanal", "Tripathi" }
                });
        }
    }
}
