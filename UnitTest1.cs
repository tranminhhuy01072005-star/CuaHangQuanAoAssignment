using CuaHangQuanAo.API.Controllers;
using CuaHangQuanAo.Data;
using CuaHangQuanAo.Data.Entities;
using Microsoft.AspNetCore.Hosting; // Thêm cái này
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq; // Nếu chưa có, Huy gõ Install-Package Moq trong Console nhé
using Xunit;

namespace CuaHangQuanAo.Tests
{
    public class UnitTest1
    {
        private AppDbContext GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: System.Guid.NewGuid().ToString())
                .Options;

            var databaseContext = new AppDbContext(options);
            databaseContext.Database.EnsureCreated();
            return databaseContext;
        }

        [Fact]
        public async Task Test_GetProducts_Success()
        {
            // 1. Chuẩn bị DB
            var db = GetDatabaseContext();

            // 2. Tạo "hàng giả" cho IWebHostEnvironment (Vì Test không có môi trường web thật)
            var mockEnvironment = new Mock<IWebHostEnvironment>();

            // 3. Truyền CẢ HAI vào đây (Hết đỏ chắc chắn!)
            var controller = new ProductsController(db, mockEnvironment.Object);

            // 4. Chạy hàm (Hàm của Huy tên là GetProducts nhé)
            var result = await controller.GetProducts(null, null, null, 1, 10);

            // 5. Kiểm tra
            Assert.IsType<OkObjectResult>(result);
        }
    }
}