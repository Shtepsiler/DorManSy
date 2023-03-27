using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "dormitories",
                columns: new[] { "Id", "Address", "FloorsNumber", "Manager", "Number", "RoomsNumber", "Year" },
                values: new object[] { 1, "Chernivtsi, Nebesnoyi Sotni 4B", 5, "Valera", 3, 50, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "Id", "BedsNumder", "DormintoryId", "DormitoryId", "Numder", "Payment" },
                values: new object[] { 1, 2, 0, null, 116, 2000.0 });

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Item", "RoomId", "Year", "code" },
                values: new object[] { 1, "шафа", 1, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 68234354L });

            migrationBuilder.InsertData(
                table: "inmates",
                columns: new[] { "Id", "Name", "RoomId", "Status", "Surname", "isPaid" },
                values: new object[,]
                {
                    { 1, "Misha", 1, "student", "Hordashuk", true },
                    { 2, "Vasia", 1, "student", "Fammilia", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dormitories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "inmates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "inmates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
