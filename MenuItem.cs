using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public void Print()
        {
            Console.WriteLine(Name + "\t" + Category + "\t" + Description + "\t" + Price + "$");
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            MenuItem itemObj = obj as MenuItem;
            return Description == itemObj.Description;
        }
    }
}

/*
 * several menu items
 * these items are app/main/dessert
 * 
 * each manu items have
 * price/desc/category
 * 
 * new/not
 * 
 * last update
 * 
 * main method is admin page
 * can add items to menu
 * print out menu
 */
