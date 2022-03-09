using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migration_5_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "CartItem",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 36, 53, 183, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 36, 53, 185, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "CartItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 24, 23, 65, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 1, 23, 24, 23, 67, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
