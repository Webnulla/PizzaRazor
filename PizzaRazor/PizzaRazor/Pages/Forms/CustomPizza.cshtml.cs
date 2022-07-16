using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;

namespace PizzaRazor.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty]
    public PizzasEntity Pizza { get; set; }

    public float PizzaPrice { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;

        if (Pizza.TomatoSauce) PizzaPrice += 1;
        if (Pizza.Cheese) PizzaPrice += 1;
        if (Pizza.Beef) PizzaPrice += 3;
        if (Pizza.Ham) PizzaPrice += 2;
        if (Pizza.Mushroom) PizzaPrice += 1;
        if (Pizza.Tuna) PizzaPrice += 4;
        if (Pizza.Pineapple) PizzaPrice += 2;

        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
    }
}