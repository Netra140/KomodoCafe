using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace ConsoleUI
{
    class ProgramUI
    {
        MenuRepo Repo { get; set; }
        public ProgramUI(MenuRepo MenuRepo)
        {
            Repo = MenuRepo;
        }
        public void Commands()
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the Komodo Cafe Menu Manager!");
                Console.WriteLine("Type 'Help' for a list of commands");
                string commands = Console.ReadLine();
                if (commands == "Help" || commands == "help")
                {
                    Console.WriteLine("Type 'Add' to add a Menu, Type 'Menu' to modify a Menu, Type 'List' to see a list of all registered Menus, Type 'Done' to exit the program.");
                }
                else if (commands == "Add" || commands == "add")
                {
                    Console.WriteLine("Please put a number for the menu item.");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Put a name for the order");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Describe the item for the menu.");
                    string description = Console.ReadLine();
                    Console.WriteLine("Put the cost of the item.");
                    double cost = double.Parse(Console.ReadLine());
                    bool repie = false;
                    List<string> recipie = new List<string>();
                    while (!repie)
                    {
                        Console.WriteLine("Put the ingredients in the recipie or put 'Done' to move on.");
                        string ingredient = Console.ReadLine();
                        if (ingredient == "Done" || ingredient == "done")
                        {
                            repie = true;
                        }
                        else
                        {
                            recipie.Add(ingredient);
                        }
                    }
                    MenuPoco Menu = new MenuPoco(num, nombre, description, recipie, cost);
                    Repo.AddMenu(Menu);
                }
                else if (commands == "Remove" || commands == "remove")
                {
                    Console.WriteLine("Put the order number of the menu item you wish to delete or type 'Cancel'");
                    string execute = Console.ReadLine();
                    if (execute == "Cancel" || execute == "cancel")
                    {

                    }
                    else
                    {
                        List<MenuPoco> _Menus = Repo.GetList();
                        for (int i = 0; i < _Menus.Count; i++)
                        {
                            if (_Menus[i].combo == int.Parse(execute))
                            {
                                Repo.Remove(i);
                            }
                        }
                    }
                }
                else if (commands == "List" || commands == "list")
                {
                    List<MenuPoco> _Menus = Repo.GetList();
                    for (int i = 0; i < _Menus.Count; i++)
                    {
                        string list = "";
                        list += "$" + _Menus[i].price + " - #" + _Menus[i].combo + " " + _Menus[i].mealName + ": " + _Menus[i].description;
                        Console.WriteLine(list);
                        for (int j = 0; j < _Menus[i].ingredients.Count; j++)
                        {
                            Console.WriteLine("    -  " + _Menus[i].ingredients[j]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (commands == "Done" || commands == "done")
                {
                    done = true;
                }
            }
        }
    }
}
