namespace WebApplication4.Model;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public ICollection<Product> Products { get; set; }
}