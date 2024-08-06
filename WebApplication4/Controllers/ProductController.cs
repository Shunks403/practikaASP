using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Model;

namespace WebApplication4.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController: ControllerBase
{
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
    {
        return await _context.Product.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult> AddProduct([FromBody] Product product)
    {
        //тут хочу валидацию , но думаю сделать потом дто и тд , так что не трачу время щас 
        _context.Product.Add(product);
        await _context.SaveChangesAsync();
        return Created();
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        var product = await _context.Product.FindAsync(id);
        
        _context.Product.Remove(product);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<Product>> UpdatePatchProduct(int id, [FromBody] float price)
    {
        var product = await _context.Product.FindAsync(id);
        product.price = price;
        await _context.SaveChangesAsync();
        return Ok(product);
    }
    //<-------------------------------------------------------------------------------------------->
    
    
    
    
}