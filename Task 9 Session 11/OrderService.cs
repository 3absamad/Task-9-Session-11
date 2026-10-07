using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_Session_11
{
    public class OrderService
    {
        public static event Action<Order> orderProcessed;

        public static void ProcessOrder(Order order)
        {
            Console.WriteLine($"Processing Order {order.Id}...");

            Console.WriteLine("Order processed successfully.");

            orderProcessed?.Invoke(order);
        }


        public delegate decimal PriceCalculator(Order order);

        public static decimal CalculateTotal(Order order) => order.Price * order.Quantity;

        public static decimal CalculateTotalWithDiscount(Order order)
        {
            decimal total = order.Price * order.Quantity;

            // 10% discount
            return total * 0.90m;
        }

        //User-Defined Delegate Function
        public static decimal CalculateOrderPrice1(Order order, PriceCalculator priceCalculator) => priceCalculator(order);

        //Built-In Delegate Function (Func)
        public static decimal CalculateOrderPrice2(Order order, Func<Order, decimal> calculator) => calculator(order);

        //Built-In Delegate Function (Predicate)
        public static bool ValidateOrder(Order order, Predicate<Order> validationRule) => validationRule(order);

        //Built-In Delegate Function (Action)
        public static void ProcessOrder(Order order, Action<Order> action) => action(order);

    }
}
