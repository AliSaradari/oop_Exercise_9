using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_9
{
    public static class FastFood
    {
        private static List<Customer> _customers = new();
        //private static List<Food> _menu = new();
        public static void AddCustomer(string customerId, string customerAddress)
        {
            var customer = new Customer(customerId, customerAddress);
            _customers.Add(customer);
        }
        public static void ShowIngredients(int option)
        {
            switch (option)
            {
                case 1:
                    {
                        var pizza = new Pizza(0);
                        pizza.ShowIngredients();
                        break;
                    }
                case 2:
                    {
                        var pasta = new Pasta(0);
                        pasta.ShowIngredients();
                        break;
                    }
            }

        }
        public static void AddOrder(string customerId, int orderOption, int count)
        {
            var customer = _customers.Single(_ => _.CustomerId == customerId);
            switch (orderOption)
            {
                case 1:
                    {
                        var pizza = new Pizza(count);
                        customer.AddToCustomerOrderList(pizza);
                        break;
                    }
                case 2:
                    {
                        var pasta = new Pasta(count);
                        customer.AddToCustomerOrderList(pasta);
                        break;
                    }
            }
        }
        public static void ShowCustomerOrder(string customerId)
        {
            var customer = _customers.Single(x => x.CustomerId == customerId);
            var foodList = customer.GetOrderedFood();
            foreach (var order in foodList)
            {
                Console.WriteLine($"Food Name: {order.CustomerOrderedFood.Name} * {order.CustomerOrderedFood.Count} Price = {order.CustomerOrderedFood.Count * order.CustomerOrderedFood.Price}");
            }
        }

    }
}
