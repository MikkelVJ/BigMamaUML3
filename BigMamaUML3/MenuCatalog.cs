using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> _menu;

        public MenuCatalog()
        {
            _menu = new List<IMenuItem>();
        }

        public int Count { get; }
        public void Add(IMenuItem aMenuItems)
        {
            if (Search(aMenuItems.Number) == null)
                _menu.Add(aMenuItems);
            else
            {
                MenuItemNumberExist mex = new MenuItemNumberExist("Menu error: It is not possible to add an item that already exists!");
                throw mex;
            }
            
        }

        public IMenuItem Search(int number)
        {
            foreach (IMenuItem m in _menu)
            {
                try
                {
                    if (m.Number == number)
                    {
                        return m;
                    }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return null;
        }

        public void Delete(int number)
        {
            IMenuItem m = Search(number);
            if (m != null)
                    _menu.Remove(m);
        }

        public void PrintPizzasMenu()
        {
            foreach (IMenuItem p in _menu)
            {
                if (p is Pizza)
                {
                    Console.WriteLine(p.PrintInfo());

                }
            }
        }

        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem b in _menu)
            {
                if (b is Beverage)
                {
                    Console.WriteLine(b.PrintInfo());

                }
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (IMenuItem t in _menu)
            {
                if (t is Topping)
                {
                    Console.WriteLine(t.PrintInfo());

                }
            }
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            IMenuItem m = Search(number);
            for (int i = 0; i < _menu.Count; i++)
            {
                if (_menu[i].Number == number)
                {
                    _menu[i] = theMenuItem;
                    return;
                }
            }
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> tempVeganList = new List<IMenuItem>();
            foreach (IMenuItem m in _menu)
            {
                if (m.IsVegan == true)
                {
                    tempVeganList.Add(m);
                }
            }

            foreach (IMenuItem v in tempVeganList)
            {
                Console.WriteLine(v.PrintInfo());
            }

            return null;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> tempOrganicList = new List<IMenuItem>();
            foreach (IMenuItem m in _menu)
            {
                if (m.IsVegan == true)
                {
                    tempOrganicList.Add(m);
                }
            }

            foreach (IMenuItem v in tempOrganicList)
            {
                Console.WriteLine(v.PrintInfo());
            }

            return null;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem max = new MenuItem(0, "", "", -1, MenuType.Pizza, false, false);
            foreach (IMenuItem m in _menu)
            {
                if (m.Price > max.Price)
                {
                    max = m;
                }
            }
            // Redundant else statement??? HELP
            if (max.Price > -1)
            {
                return max;
            }
            else
            {
                return null;

            }
        }
    }
}
