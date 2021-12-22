using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Repository;

namespace MenuTest
{
    [TestClass]
    public class MenuTesting
    {
        [TestMethod]
        public void AddTest()
        {
            MenuRepo repository = new MenuRepo();
            //Arrange
            repository._Menus = new List<MenuPoco>() { new MenuPoco(5, "Crunchwrap", "A wrap with crunch", new List<string> { "Crunch", "Wrap" }, 4.00) };
            //Act
            repository.AddMenu(new MenuPoco(7, "Quesodilla", "Folded cheesy tortilla", new List<string> { "Tortilla", "Cheese" }, 5.00));
            //Assert
            Assert.AreEqual(2, repository._Menus.Count);
        }
        [TestMethod]
        public void RemoveTest()
        {
            MenuRepo repository = new MenuRepo();

            repository._Menus = new List<MenuPoco>() { new MenuPoco(5, "Crunchwrap", "A wrap with crunch", new List<string> { "Crunch", "Wrap" }, 4.00), new MenuPoco(7, "Quesodilla", "Folded cheesy tortilla", new List<string> { "Tortilla", "Cheese" }, 5.00) };

            repository.Remove(0);

            Assert.IsTrue(repository._Menus.Count == 1 && repository._Menus[0].mealName == "Quesodilla");
        }
        [TestMethod]
        public void ListTest()
        {
            MenuRepo repository = new MenuRepo();
            repository._Menus = new List<MenuPoco>() { new MenuPoco(5, "Crunchwrap", "A wrap with crunch", new List<string> { "Crunch", "Wrap" }, 4.00), new MenuPoco(7, "Quesodilla", "Folded cheesy tortilla", new List<string> { "Tortilla", "Cheese" }, 5.00) };
            List<MenuPoco> result = repository.GetList();
            Assert.AreEqual(2, result.Count);
        }
    }
}
