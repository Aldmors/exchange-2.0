using System;
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
                name: "Authentication",
                columns: table => new
                {
                    AuthenticationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    TwoFa = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentication", x => x.AuthenticationId);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Type = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Status = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    AdditionalInfo = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    LabelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingType = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    ShippingId = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Status = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Country = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.LabelId);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statistics = table.Column<bool>(type: "bit", nullable: false),
                    CreateUsers = table.Column<bool>(type: "bit", nullable: false),
                    EditUsers = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUsers = table.Column<bool>(type: "bit", nullable: false),
                    CreateGroups = table.Column<bool>(type: "bit", nullable: false),
                    EditGroups = table.Column<bool>(type: "bit", nullable: false),
                    DeleteGroups = table.Column<bool>(type: "bit", nullable: false),
                    ProblemSolving = table.Column<bool>(type: "bit", nullable: false),
                    Packaging = table.Column<bool>(type: "bit", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    PermissionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalId = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    FirstName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    SecondName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    PasswordAuthenticationId = table.Column<int>(type: "int", nullable: true),
                    PermissionId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Authentication_PasswordAuthenticationId",
                        column: x => x.PasswordAuthenticationId,
                        principalTable: "Authentication",
                        principalColumn: "AuthenticationId");
                    table.ForeignKey(
                        name: "FK_User_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId");
                    table.ForeignKey(
                        name: "FK_User_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_PermissionId",
                table: "Group",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GroupId",
                table: "User",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PasswordAuthenticationId",
                table: "User",
                column: "PasswordAuthenticationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PermissionId",
                table: "User",
                column: "PermissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Authentication");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Permission");
        }
    }
}
