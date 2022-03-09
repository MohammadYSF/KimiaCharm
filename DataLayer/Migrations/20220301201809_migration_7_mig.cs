using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migration_7_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartID", "TotalPrice" },
                values: new object[] { 1, 0m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 48, 9, 683, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 48, 9, 686, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 48, 9, 686, DateTimeKind.Local).AddTicks(2658));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 47, 38, 593, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 47, 38, 595, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 47, 38, 595, DateTimeKind.Local).AddTicks(744));
        }
    }
}
