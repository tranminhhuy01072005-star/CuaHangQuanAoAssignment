namespace CuaHangQuanAo.Data.Entities;

public class Cart // Thêm chữ public vào đây
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}