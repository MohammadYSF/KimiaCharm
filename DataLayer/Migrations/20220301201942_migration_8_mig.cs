using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migration_8_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "CartItemID", "CartID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 1, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 49, 42, 557, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 49, 42, 560, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 49, 42, 560, DateTimeKind.Local).AddTicks(5515));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartItem",
                keyColumn: "CartItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItem",
                keyColumn: "CartItemID",
                keyValue: 2);

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
    }
}
