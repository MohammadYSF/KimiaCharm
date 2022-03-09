using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class edit_model_product_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "HorizontalImageName",
                table: "Product",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VerticalImageName",
                table: "Product",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 810, DateTimeKind.Local).AddTicks(745), "1.jpg", "1.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(149), "2.jpg", "2.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(225), "3.jpg", "3.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(230), "4.jpg", "4.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(233), "5.jpg", "5.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(236), "6.jpg", "6.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(239), "7.jpg", "7.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "Date", "HorizontalImageName", "VerticalImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(241), "8.jpg", "8.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorizontalImageName",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "VerticalImageName",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 814, DateTimeKind.Local).AddTicks(8333), "1.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8500), "2.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8578), "3.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8586), "4.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8591), "5.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8595), "6.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8601), "7.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8605), "8.jpg" });
        }
    }
}
