using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Data;
using PizzaRazor.Models;

namespace PizzaRazor.Pages.Checkout;
[BindProperties(SupportsGet = true)]

public class Checkout : PageModel
{
    public string PizzaName { get; set; }
    public string ImageTitle { get; set; }
    public float PizzaPrice { get; set; }
    
    private readonly ApplicationDbContext _context;

    public Checkout(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName))
        {
            PizzaName = "Custom";
        }

        if (string.IsNullOrWhiteSpace(ImageTitle))
        {
            ImageTitle = "Create";
        }

        var pizzaOrder = new PizzaOrder();
        pizzaOrder.PizzaName = PizzaName;
        pizzaOrder.BasePrice = PizzaPrice;

        _context.PizzaOrders.Add(pizzaOrder);
        _context.SaveChanges();
    }
}