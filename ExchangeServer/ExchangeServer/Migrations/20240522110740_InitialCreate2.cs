using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExchangeServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authentication",
                columns: table => new
                {
                    AuthenticationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Password = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    TwoFa = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentication", x => x.AuthenticationId);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    ShipmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.ShipmentId);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShipmentId = table.Column<int>(type: "integer", nullable: false),
                    DocumentName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Type = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Status = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    AdditionalInfo = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Document_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "ShipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExternalOrder",
                columns: table => new
                {
                    ExternalOrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    ShipmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalOrder", x => x.ExternalOrderId);
                    table.ForeignKey(
                        name: "FK_ExternalOrder_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "ShipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    LabelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShippingType = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    ShippingId = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Status = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Country = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ShipmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.LabelId);
                    table.ForeignKey(
                        name: "FK_Label_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "ShipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExternalId = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    FirstName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    SecondName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Status = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AuthenticationId = table.Column<int>(type: "integer", nullable: true),
                    ShipmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Authentication_AuthenticationId",
                        column: x => x.AuthenticationId,
                        principalTable: "Authentication",
                        principalColumn: "AuthenticationId");
                    table.ForeignKey(
                        name: "FK_User_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "ShipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    SecondName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Address = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    StreetNumber = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    State = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    PostalCode = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Country = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Notes = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    ExternalOrderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Client_ExternalOrder_ExternalOrderId",
                        column: x => x.ExternalOrderId,
                        principalTable: "ExternalOrder",
                        principalColumn: "ExternalOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Statistics = table.Column<bool>(type: "boolean", nullable: false),
                    CreateUsers = table.Column<bool>(type: "boolean", nullable: false),
                    EditUsers = table.Column<bool>(type: "boolean", nullable: false),
                    DeleteUsers = table.Column<bool>(type: "boolean", nullable: false),
                    CreateGroups = table.Column<bool>(type: "boolean", nullable: false),
                    EditGroups = table.Column<bool>(type: "boolean", nullable: false),
                    DeleteGroups = table.Column<bool>(type: "boolean", nullable: false),
                    ProblemSolving = table.Column<bool>(type: "boolean", nullable: false),
                    Packaging = table.Column<bool>(type: "boolean", nullable: false),
                    Admin = table.Column<bool>(type: "boolean", nullable: false),
                    GroupId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                    table.ForeignKey(
                        name: "FK_Permission_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_ExternalOrderId",
                table: "Client",
                column: "ExternalOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Document_ShipmentId",
                table: "Document",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalOrder_ShipmentId",
                table: "ExternalOrder",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Group_UserId",
                table: "Group",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Label_ShipmentId",
                table: "Label",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_GroupId",
                table: "Permission",
                column: "GroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_UserId",
                table: "Permission",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_AuthenticationId",
                table: "User",
                column: "AuthenticationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ShipmentId",
                table: "User",
                column: "ShipmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "ExternalOrder");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Authentication");

            migrationBuilder.DropTable(
                name: "Shipment");
        }
    }
}
