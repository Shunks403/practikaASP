using Microsoft.EntityFrameworkCore;
using WebApplication4.Model;

namespace WebApplication4.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Product> Product { get; set; }
}