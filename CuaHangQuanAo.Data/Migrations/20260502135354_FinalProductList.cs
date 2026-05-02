using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CuaHangQuanAo.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinalProductList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 11, 1, "Hoodie Kenzo thêu mặt hổ sắc nét", "/images/ao6.jpg", "Áo Hoodie Kenzo mặt hổ", 1450000m, 15 },
                    { 12, 1, "Họa tiết Cherry đặc trưng của Gucci", "/images/ao7.jpg", "Áo phông Gucci Cheeryfy", 850000m, 25 },
                    { 13, 1, "Dsquared2 Icon đơn giản mà chất", "/images/ao8.jpg", "Áo phông DSQ ICON trắng", 750000m, 30 },
                    { 14, 1, "Louis Vuitton thêu hoa tỉ mỉ", "/images/ao9.jpg", "Áo phông LV thêu hoa", 1150000m, 20 },
                    { 15, 1, "Họa tiết Dog King quyền lực", "/images/ao10.jpg", "Áo phông Dolce Dog King", 950000m, 18 },
                    { 16, 3, "Balo Dior sang trọng đẳng cấp", "/images/balo3.jpg", "Balo Christian Dior", 2500000m, 10 },
                    { 17, 3, "Balo Gucci họa tiết monogram xám", "/images/balo4.jpg", "Balo Gucci xám trắng", 1800000m, 12 },
                    { 18, 2, "Quần nỉ bo gấu mặc cực thoải mái", "/images/quan4.jpg", "Quần dài nỉ Gucci đen", 650000m, 40 },
                    { 19, 2, "Quần đùi thời trang đi biển cực cháy", "/images/quan5.jpg", "Quần đùi Gucci", 450000m, 50 },
                    { 20, 2, "Jean Dsquared2 khóa kéo phong cách", "/images/quan6.jpg", "Quần jean khóa kéo D2Q", 880000m, 22 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
