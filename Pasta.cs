using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_9
{
    public class Pasta : Food
    {
        public Pasta(int count) : base(count)
        {
            Name = "Pasta";
            Price = 15;
        }
        public override void ShowIngredients()
        {
            Console.WriteLine("Pasta Ingredients: Pene , Alfredo sauce , Chiken ... ");
        }
    }
}
