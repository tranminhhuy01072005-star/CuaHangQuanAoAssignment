namespace CuaHangQuanAo.Data.Entities;

public class CartItem // Thêm chữ public vào đây
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public  Cart? Cart { get; set; } // Kiểm tra xem Cart ở đây có bị lỗi không

    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}