using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BigMamaUML3
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCatalog c = new MenuCatalog();
            MenuItemNumberExist mex = new MenuItemNumberExist();

            Pizza p1 = new Pizza(01,"Vesuvio", "Tomato, Cheese, Ham",60, MenuType.Pizza,false,true);
            Pizza p2 = new Pizza(02,"Hawaii", "Tomato, Cheese, Ham, Pineapple", 65, MenuType.Pizza, false, false);

            Beverage b1 = new Beverage(03, "Cola", "Cold, 50cl", 20, MenuType.SoftDrink, true, false);
            Beverage b2 = new Beverage(04, "Beer", "Cold, 50cl", 20, MenuType.AlcoholicDrink, true, true);

            Topping t1 = new Topping(05, "Pepperoni", "Extra Pepperoni", 10, MenuType.Topping, false, false);
            Topping t2 = new Topping(06, "Sausage", "Extra sausage", 5, MenuType.Topping, false, false);

            c.Add(p1);
            c.Add(p2);
            c.Add(b1);
            c.Add(b2);
            c.Add(t1);
            c.Add(t2);

            c.PrintPizzasMenu();
            c.PrintBeveragesMenu();
            c.PrintToppingsMenu();

            c.Delete(06);

            c.PrintToppingsMenu();
            try
            {
                c.Add(p1);

            }
            catch (MenuItemNumberExist e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
