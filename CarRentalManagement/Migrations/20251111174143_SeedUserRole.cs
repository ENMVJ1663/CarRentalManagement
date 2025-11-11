using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Adminstrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5c0fdfe9-3dcd-4abe-bc5d-d72bcab5d7c5", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEL7UPdSG9C8YRQR/maF0Ko4OReadxPNfqnyd4dPmkwXog8Wt/02d8qVsTPQbSQ2pNA==", null, false, "19a30251-3fbc-4596-96a4-e49755a8bd0b", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4602), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4625), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4990), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4995), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5131), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5135), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5139), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5142), new DateTime(2025, 11, 12, 0, 36, 3, 13, DateTimeKind.Local).AddTicks(5142) });
        }
    }
}
