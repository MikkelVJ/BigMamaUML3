using BigMamaUML3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuCatalogTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddingPizzaToMenu()
        {
            IMenuCatalog m = new MenuCatalog();
            IMenuItem Pizza = new MenuItem(1, "Pizza", "A pizza", 30, MenuType.Pizza, false, true);

            m.Add(Pizza);

            int eresult = 1;

            Assert.IsTrue(true, "", m.Count == eresult);

        }
        [TestMethod]
        public void AddingPizzaToMenuAndThenSearchingForIt()
        {
            // Arrange
            MenuCatalog _menutest = new MenuCatalog();
            IMenuItem Pizza = new MenuItem(1, "Pizza", "A pizza", 30, MenuType.Pizza, false, true );
            IMenuItem expectedresult = Pizza;

            // Act
            _menutest.Add(Pizza);
            _menutest.Search(1);

            // Assert
            Assert.AreSame(expectedresult, _menutest.Search(1));
        }

        [TestMethod]
        public void FindMostExpensivePizza()
        {
            // Arrange
            MenuCatalog m = new MenuCatalog();

            IMenuItem Pizza = new MenuItem(1, "Pizza", "A pizza", 30, MenuType.Pizza, false, true);
            IMenuItem ExpensivePizza = new MenuItem(2, "EPizza", "An expensive pizza", 60, MenuType.Pizza, false, true);

            // Act
            IMenuItem expectedResult = ExpensivePizza;

            // Assert
            Assert.AreSame(expectedResult, m.MostExpensiveMenuItem());




        }
    }
}
