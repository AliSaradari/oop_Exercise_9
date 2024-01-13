using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_9
{
    public class Pizza : Food
    {
        public Pizza(int count) : base(count)
        {
            Name = "Pizza";
            Price = 25;
        }

        public override void ShowIngredients()
        {
            Console.WriteLine("Pizza Ingredients: Pizza Bread ,Piza Cheese ,Peperoni ... ");
        }
    }
}
