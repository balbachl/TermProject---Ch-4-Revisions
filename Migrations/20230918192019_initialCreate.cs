using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GenderIdentity = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Address", "Cell", "City", "Email", "FirstName", "GenderIdentity", "LastName", "State", "Zip" },
                values: new object[] { 1, null, null, null, "lbalbach@nmc.edu", "Lisa", null, "Balbach", null, null });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Address", "Cell", "City", "Email", "FirstName", "GenderIdentity", "LastName", "State", "Zip" },
                values: new object[] { 2, null, null, null, null, "Shaggy", null, "Rogers", null, null });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Address", "Cell", "City", "Email", "FirstName", "GenderIdentity", "LastName", "State", "Zip" },
                values: new object[] { 3, null, null, null, null, "Daphne", null, "Blake", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membership");
        }
    }
}
