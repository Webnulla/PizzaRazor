using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;

namespace PizzaRazor.Pages;

public class Pizza : PageModel
{
    public List<PizzasEntity> fakePizzaDb = new List<PizzasEntity>()
    {
        new PizzasEntity()
        {
            ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true,
            FinalPrice = 4
        },
        new PizzasEntity()
        {
            ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, Cheese = true, Beef = true,
            TomatoSauce = true, FinalPrice = 6
        },
        new PizzasEntity()
        {
            ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, Cheese = true, TomatoSauce = true,
            Mushroom = true, Beef = true, FinalPrice = 8
        },
        new PizzasEntity()
        {
            ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, Cheese = true, Pineapple = true,
            Tuna = true, FinalPrice = 15
        },
        new PizzasEntity()
        {
            ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 2, Beef = true, Cheese = true, Ham = true,
            FinalPrice = 6
        },
        new PizzasEntity()
        {
            ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, Mushroom = true, Cheese = true, Beef = true,
            FinalPrice = 6
        },
        new PizzasEntity()
        {
            ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, TomatoSauce = true, Cheese = true,
            FinalPrice = 4
        },
        new PizzasEntity()
        {
            ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, Tuna = true, Cheese = true,
            TomatoSauce = true, Mushroom = true, FinalPrice = 8
        },
        new PizzasEntity()
        {
            ImageTitle = "Vegetarian", PizzaName = "Vegeratian", BasePrice = 2, TomatoSauce = true, FinalPrice = 2
        }
    };

    public void OnGet()
    {
    }
}