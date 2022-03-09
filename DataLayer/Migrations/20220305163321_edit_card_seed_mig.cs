using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class edit_card_seed_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                columns: new[] { "ProductsTotalPrice", "TotalPrice" },
                values: new object[] { 40000000m, 40030000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 482, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 3, 5, 20, 3, 21, 485, DateTimeKind.Local).AddTicks(9256));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                columns: new[] { "ProductsTotalPrice", "TotalPrice" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 82, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 32, 52, 85, DateTimeKind.Local).AddTicks(751));
        }
    }
}
