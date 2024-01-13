using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_9
{
    public abstract class Food
    {
        private string _name;
        private int _price;
        private int _count;
        protected Food(int count)
        {
            Count = count;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new Exception("Food Name Cannot Be Empty"); }
                _name = value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0) { throw new Exception("Food Price Cannot Be Negative"); }
                _price = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value < 0) { throw new Exception("Food Count Cannot Be Negative"); }
                _count = value;
            }
        }
        public abstract void ShowIngredients();
    }
}
