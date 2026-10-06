using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_Session_11
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order(int id, string name, decimal price, int quantity)
        {
            Id = id;
            CustomerName = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
