using Microsoft.EntityFrameworkCore;

public class Datacontext:DbContext
{
    public Datacontext(DbContextOptions<Datacontext> options) : base(options)
    {
        
    }
   public DbSet<Products> products {get; set;}
    
}