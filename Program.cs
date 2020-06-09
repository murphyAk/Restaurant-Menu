using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            // set time
            DateTime today = DateTime.Now;

            //create menu items
            MenuItem pizza = new MenuItem("Pizza", 14.99, "it's a pizza", "Main Course", true);
            MenuItem pasta = new MenuItem("Pasta", 12.99, "it's a pasta", "Main Course", true);
            MenuItem soup = new MenuItem("Soup", 4.99, "it's a soup", "Appetizer", true);
            MenuItem cake = new MenuItem("Cake", 9.99, "it's a cake", "Dessert", true);

            List<MenuItem> menuList = new List<MenuItem>() { pizza, pasta, soup, cake };

            Menu ourMenu = new Menu(today, menuList);

            //ourMenu.Print();

            MenuItem pie = new MenuItem("Pie", 5.99, "it's a pie", "Dessert", true);

            ourMenu.AddItem(pie);

            //ourMenu.RemoveItem(cake);

            ourMenu.Print();







            //List<string> menuItems = new List<string>();

            //bool isValidOption;

            //do
            //{
            //    Console.WriteLine("Option List:\n0: exit\n1: View Menu\n2: Add item\n3: Remove item\n\n3Choose an option:");
            //    string selection = Console.ReadLine();

            //    switch (selection)
            //    {
            //        case "0":
            //            Console.WriteLine("Good-Bye");
            //            isValidOption = true;
            //            break;
            //        case "1":
            //            Console.WriteLine("view menu");
            //            //PrintMenu(allMenuItems);
            //            // create print menu method that takes in a dictionary of all menu items
            //            isValidOption = true;
            //            break;
            //        case "2":
            //            Console.WriteLine("add menu");
            //            isValidOption = true;
            //            break;
            //        case "3":
            //            Console.WriteLine("remove menu");
            //            isValidOption = true;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input. Try again\n");
            //            isValidOption = false;
            //            break;
            //    }
            //} while (!isValidOption);
        }
    }
}
