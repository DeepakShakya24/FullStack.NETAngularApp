using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace angularbackend.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AngularEmployee",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmnet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AngularEmployee", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AngularEmployee");
        }
    }
}
