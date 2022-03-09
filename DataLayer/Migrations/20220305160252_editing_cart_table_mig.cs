using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class editing_cart_table_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PostingPrice",
                table: "Cart",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductsTotalPrice",
                table: "Cart",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "PostingPrice",
                value: 30000m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostingPrice",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "ProductsTotalPrice",
                table: "Cart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 810, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(241));
        }
    }
}
