using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExchangeServerAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    SecondName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Address = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    StreetNumber = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    State = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    PostalCode = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Country = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Notes = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
