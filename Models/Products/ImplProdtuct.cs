using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
    private readonly Datacontext _context;

    public ProductRepository(Datacontext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Products>> GetAllProductsAsync()
    {
        return await _context.products.ToListAsync();
    }

    public async Task<Products> GetProductByIdAsync(int id)
    {
        return await _context.products.FindAsync(id);
    }

    public async Task AddProductAsync(Products product)
    {
        _context.products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Products product)
    {
        _context.products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(int id)
    {
        var product = await _context.products.FindAsync(id);
        if (product != null)
        {
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}