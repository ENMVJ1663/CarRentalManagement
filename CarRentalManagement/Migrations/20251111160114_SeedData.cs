using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2517), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2530), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2533), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2534), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2680), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2680), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2681), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2682), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2750), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2751), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2752), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2753), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2754), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2754), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2755), new DateTime(2025, 11, 12, 0, 1, 14, 25, DateTimeKind.Local).AddTicks(2755), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
