namespace CuaHangQuanAo.Data.Entities;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = "Customer"; // Các giá trị: Admin, Customer

    // Một Role có thể có nhiều User (1 - n)
    public ICollection<User> Users { get; set; } = new List<User>();
}