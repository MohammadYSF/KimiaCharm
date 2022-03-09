using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class adding_user_and_role_table_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 300, nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    HashedPassword = table.Column<string>(nullable: false),
                    DateOfRegisteration = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 603, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2022, 3, 8, 16, 53, 34, 606, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

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
    }
}
