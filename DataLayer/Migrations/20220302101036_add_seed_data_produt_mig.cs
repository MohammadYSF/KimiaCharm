using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class add_seed_data_produt_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8586), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "4.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" },
                    { 5, 1, new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8591), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "5.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" },
                    { 6, 1, new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8595), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "6.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" },
                    { 7, 2, new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8601), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "7.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" },
                    { 8, 1, new DateTime(2022, 3, 2, 13, 40, 35, 816, DateTimeKind.Local).AddTicks(8605), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "8.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 1, 23, 49, 42, 557, DateTimeKind.Local).AddTicks(788), "ufhaushf.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 1, 23, 49, 42, 560, DateTimeKind.Local).AddTicks(5431), "123awr.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Date", "ImageName" },
                values: new object[] { new DateTime(2022, 3, 1, 23, 49, 42, 560, DateTimeKind.Local).AddTicks(5515), "123awr.jpg" });
        }
    }
}
