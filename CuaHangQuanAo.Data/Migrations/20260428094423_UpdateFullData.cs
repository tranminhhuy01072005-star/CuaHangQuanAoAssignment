using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CuaHangQuanAo.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFullData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Quần ");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phụ Kiện" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { "Hàng cao cấp chữ nổi cực nét", "/images/0609905f-e19d-4626-90b9-19b39fc25169.jpg", "Áo LV xám chữ nổi", 1250000m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { 1, "Phong cách boy phố trẻ trung", "/images/356b1fa5-1389-4d4c-91bf-47927aad56c8.jpg", "Áo len tay dài boy phố", 450000m, 30 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 3, 1, "Sơ mi họa tiết sang chảnh", "/images/c8835fcc-32a7-4902-a0a4-99a27087baa5.jpg", "Áo sơ mi Gucci", 950000m, 20 },
                    { 4, 1, "Thương hiệu Mikenko chính hãng", "/images/cf7bc697-39ad-44f7-b9d3-97629d60d46a.jpg", "Áo Mikenko đen hình nổi", 550000m, 45 },
                    { 5, 1, "Phiên bản giới hạn cho fan MU", "/images/9bab3251-da03-4fd3-973f-ead6791e7973.jpg", "Áo Adidas Man United bản đặc biệt", 850000m, 15 },
                    { 8, 2, "Chất jean co giãn tốt", "/images/0e66918c-3e38-48e0-a528-01d436e997fe.jpg", "Quần jean đen trơn", 380000m, 100 },
                    { 9, 2, "Phong cách bụi bặm", "/images/f0b1ebd7-133d-4596-868b-ec80974961f6.jpg", "Quần jean rách gối vẩy sơn", 420000m, 40 },
                    { 10, 2, "Dáng suông thoải mái", "/images/2ae057f9-3f68-4549-bf1a-67945ab121fc.jpg", "Quần ống rộng túi hộp", 350000m, 60 },
                    { 6, 3, "Balo Jordan thời trang", "/images/c17f15fa-5691-4a80-acad-46e77a7e70ac.jpg", "Balo JD Trắng", 650000m, 25 },
                    { 7, 3, "Họa tiết monogram kinh điển", "/images/ed492643-cecc-4871-ab43-c377e059fc40.jpg", "Balo LV Nâu", 1500000m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Quần Tây");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Sơ mi cao cấp", "Áo Sơ mi Trắng", 250000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 2, "Quần tôn dáng", "Quần Âu Slimfit", 350000m });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin" });
        }
    }
}
