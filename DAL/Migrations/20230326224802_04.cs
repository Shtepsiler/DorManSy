using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dormitories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "DormintoryId",
                table: "rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DormintoryId",
                table: "rooms");

            migrationBuilder.InsertData(
                table: "dormitories",
                columns: new[] { "Id", "Address", "FloorsNumber", "Manager", "Number", "RoomsNumber", "Year" },
                values: new object[] { 1, "Chernivtsi, Nebesnoyi Sotni 4B", 5, "Valera", 103, 50, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
