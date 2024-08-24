
using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace revision1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController:ControllerBase
    {
         private readonly IProductRepository _repository;

    public HomeController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
    {
        var products = await _repository.GetAllProductsAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Products>> GetProduct(int id)
    {
        var product = await _repository.GetProductByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult> PostProduct([FromBody] Products product)
    {
        await _repository.AddProductAsync(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.p_id }, product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutProduct(int id, [FromBody] Products product)
    {
        if (id != product.p_id)
        {
            return BadRequest();
        }

        await _repository.UpdateProductAsync(product);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        await _repository.DeleteProductAsync(id);
        return NoContent();
    }
    }
}