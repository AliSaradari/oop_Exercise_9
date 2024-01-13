using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Exercise_9
{
    public class Customer
    {
        private List<OrderedFood> _foodList;
        private string _id;
        private string _address;
        public Customer(string customerId, string customerAddress)
        {
            CustomerId = customerId;
            CustomerAddress = customerAddress;
            _foodList = new List<OrderedFood>();
        }
        public string CustomerId
        {
            get
            {
                return _id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new Exception("Customer Id Cannot Be Empty"); }
                _id = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return _address;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new Exception("Customer Address Cannot Be Empty"); }
                _address = value;
            }
        }
        public List<Food> CustomerOrder { get; private set; }
        public void AddToCustomerOrderList(Food food)
        {
            var orderedFood = new OrderedFood(food);
            _foodList.Add(orderedFood);
        }
        public List<OrderedFood> GetOrderedFood()
        {
            return _foodList;
        }
    }
    public class OrderedFood
    {
        public OrderedFood(Food food)
        {
            CustomerOrderedFood = food;
        }
        public Food CustomerOrderedFood { get; set; }
    }
}
