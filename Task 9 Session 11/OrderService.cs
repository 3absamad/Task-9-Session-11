using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_Session_11
{
    public class OrderService
    {
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

        //Built-In Delegate Function
        public static decimal CalculateOrderPrice2(Order order, Func<Order, decimal> calculator) => calculator(order);
    }
}
