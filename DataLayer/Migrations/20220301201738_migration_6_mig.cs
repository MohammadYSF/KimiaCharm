using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migration_6_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Product_ProductID",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Product",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Category",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CartItemID",
                table: "CartItem",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "Cart",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "CartItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "CartID");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "کیف" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 2, "جاهندزفری" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 1, 23, 47, 38, 593, DateTimeKind.Local).AddTicks(919), "کیف زنانه در رنگ های متنوع و ساخته شده با چرم طبیعی با قیمتی باور نکردنی ", "ufhaushf.jpg", true, "کیف;کفش;کیف زنانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی زنانه", 200000m, "یک کیف چرمی زنانه بسیار با کیفیت" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, 1, new DateTime(2022, 3, 1, 23, 47, 38, 595, DateTimeKind.Local).AddTicks(744), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "123awr.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, 2, new DateTime(2022, 3, 1, 23, 47, 38, 595, DateTimeKind.Local).AddTicks(672), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "123awr.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Product_ProductID",
                table: "CartItem",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Product_ProductID",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CartItemID",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CartItem",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "ID");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "کیف" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "جاهندزفری" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 1, 23, 36, 53, 183, DateTimeKind.Local).AddTicks(1327), "کیف زنانه در رنگ های متنوع و ساخته شده با چرم طبیعی با قیمتی باور نکردنی ", "ufhaushf.jpg", true, "کیف;کفش;کیف زنانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی زنانه", 200000m, "یک کیف چرمی زنانه بسیار با کیفیت" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, 2, new DateTime(2022, 3, 1, 23, 36, 53, 185, DateTimeKind.Local).AddTicks(3158), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "123awr.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartID",
                table: "CartItem",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Product_ProductID",
                table: "CartItem",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
