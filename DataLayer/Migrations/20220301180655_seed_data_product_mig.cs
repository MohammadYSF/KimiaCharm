using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class seed_data_product_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 1, 21, 36, 55, 281, DateTimeKind.Local).AddTicks(4045), "کیف زنانه در رنگ های متنوع و ساخته شده با چرم طبیعی با قیمتی باور نکردنی ", "ufhaushf.jpg", true, "کیف;کفش;کیف زنانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی زنانه", 200000m, "یک کیف چرمی زنانه بسیار با کیفیت" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Date", "FullDescription", "ImageName", "IsAvailable", "Keywords", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, 2, new DateTime(2022, 3, 1, 21, 36, 55, 286, DateTimeKind.Local).AddTicks(701), "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ", "123awr.jpg", false, "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر", "کیف چرمی مردانه", 300000m, "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
