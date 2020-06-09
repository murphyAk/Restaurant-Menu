using System;
using System.Collections.Generic;

namespace Restaurant_Menu
{
    class Menu
    {
        // reference DateTime for lastest update
        public DateTime LastUpdated { get; set; }

        public List<MenuItem> Items { get; set; }


        // constructor
        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }

        // add item to menu
        public List<MenuItem> AddItem(MenuItem item)
        {
            if (!Items.Contains(item))
            {
                Items.Add(item);
                LastUpdated = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Item already exists");
            }


            return Items;
        }

        // remove item from menu
        public List<MenuItem> RemoveItem(MenuItem item)
        {
            Items.Remove(item);

            return Items;
        }

        public string PrintUpdated()
        {
            return $"Date of last update: {LastUpdated}";
        }

        public void Print()
        {
            Console.WriteLine("Total Menu");

            foreach (MenuItem item in Items)
            {
                item.Print();
            }
        }
    }
}