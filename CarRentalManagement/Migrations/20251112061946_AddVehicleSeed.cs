using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "Name",
                value: "Administrator");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aa5447b-7772-476b-9303-9e6cbe09bcf1", "AQAAAAIAAYagAAAAEFH8YCVKiScjRAM4zDwH5E2LsknXru0fgWvZH/3PJ6aliih8Qu64/C/NlWXBiGoNMw==", "d18a4a64-30bd-4d55-9ace-ed80818a5896" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8575), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8600), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8780), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8854), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8857), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8858), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8860), new DateTime(2025, 11, 12, 14, 19, 45, 578, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "ColourId", "CreatedBy", "DateCreated", "DateUpdated", "LicencePlateNumber", "MakeId", "ModelId", "UpdatedBy", "Year" },
                values: new object[] { 1, 1, "System", new DateTime(2025, 11, 12, 14, 19, 45, 635, DateTimeKind.Local).AddTicks(8881), new DateTime(2025, 11, 12, 14, 19, 45, 635, DateTimeKind.Local).AddTicks(8860), "M2183UKS", 1, 1, "System", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "Name",
                value: "Adminstrator");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c0fdfe9-3dcd-4abe-bc5d-d72bcab5d7c5", "AQAAAAIAAYagAAAAEL7UPdSG9C8YRQR/maF0Ko4OReadxPNfqnyd4dPmkwXog8Wt/02d8qVsTPQbSQ2pNA==", "19a30251-3fbc-4596-96a4-e49755a8bd0b" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8057), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8075), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8214), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8216), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8277), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8279), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8281), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8282), new DateTime(2025, 11, 12, 1, 41, 42, 627, DateTimeKind.Local).AddTicks(8282) });
        }
    }
}
