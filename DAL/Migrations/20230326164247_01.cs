using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dormitories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorsNumber = table.Column<int>(type: "int", nullable: false),
                    RoomsNumber = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dormitories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "inmates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inmates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numder = table.Column<int>(type: "int", nullable: false),
                    BedsNumder = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<double>(type: "float", nullable: false),
                    DormitoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rooms_dormitories_DormitoryId",
                        column: x => x.DormitoryId,
                        principalTable: "dormitories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "furnitures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<long>(type: "bigint", nullable: false),
                    Item = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_furnitures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_furnitures_rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InmateRoom",
                columns: table => new
                {
                    InmateId = table.Column<int>(type: "int", nullable: false),
                    RoomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InmateRoom", x => new { x.InmateId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_InmateRoom_inmates_InmateId",
                        column: x => x.InmateId,
                        principalTable: "inmates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InmateRoom_rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "dormitories",
                columns: new[] { "Id", "Address", "FloorsNumber", "Manager", "Number", "RoomsNumber", "Year" },
                values: new object[] { 1, "Chernivtsi, Nebesnoyi Sotni 4B", 5, "Valera", 103, 50, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_furnitures_RoomID",
                table: "furnitures",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_InmateRoom_RoomsId",
                table: "InmateRoom",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_DormitoryId",
                table: "rooms",
                column: "DormitoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "furnitures");

            migrationBuilder.DropTable(
                name: "InmateRoom");

            migrationBuilder.DropTable(
                name: "inmates");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "dormitories");
        }
    }
}
