using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a6b9a43e-074b-463c-99cc-be827b4cbbf5", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENeB/pa/vtZUSaJDOaEnzfsl4qLMVYoCR6I41O2aJ/9mik4yWkiMk3HjBqeND5qGmg==", null, false, "1d33a733-cbe0-401d-b4b0-79f3b37574a7", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 11, 22, 11, 30, 52, 797, DateTimeKind.Local).AddTicks(3718) });

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

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8649) });
        }
    }
}
