using Microsoft.EntityFrameworkCore;
using PizzaRazor.Models;

namespace PizzaRazor.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<PizzaOrder> PizzaOrders { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}