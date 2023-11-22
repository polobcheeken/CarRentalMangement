using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6851), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(6861), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8011), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8018), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8636), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8641), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8645), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 11, 21, 15, 55, 43, 495, DateTimeKind.Local).AddTicks(8649), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
