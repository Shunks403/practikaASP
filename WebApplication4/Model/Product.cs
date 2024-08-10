namespace WebApplication4.Model;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Discription { get; set; }
    public float Price { get; set; }
    
    public int UserId { get; set; }  
    public User User { get; set; }
}