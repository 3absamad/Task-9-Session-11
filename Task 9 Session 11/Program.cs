using System.Data;
using static Task_9_Session_11.LibraryEngine;

namespace Task_9_Session_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Section 1
            //List<Book> books = new List<Book>
            //{
            //    new Book("ISBN001",
            //        "C# Programming",
            //        new string[] { "Ahmed", "Omar" },
            //        new DateTime(2025, 1, 15),
            //        500m),

            //     new Book(
            //        "ISBN002",
            //        "OOP Fundamentals",
            //        new string[] { "John" },
            //        new DateTime(2024, 5, 20),
            //        350m)
            //};

            #region User Defined Delegate

            //BookFunction mydelegate1 = BookFunctions.GetAuthors;
            //BookFunction mydelegate2 = BookFunctions.GetTitle;
            //BookFunction mydelegate3 = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBooks(books, mydelegate1);
            //LibraryEngine.ProcessBooks(books, mydelegate2);
            //LibraryEngine.ProcessBooks(books, mydelegate3);

            #endregion

            #region Built-In Delegate 

            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

            #endregion

            #region Anonymous Method

            //LibraryEngine.ProcessBooks(books, delegate (Book B){ return B.ISBN;});

            #endregion

            #region Lambda Expression

            //LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToString());

            #endregion

            #endregion

            #region Section 2

            Order order = new Order(101, "Omar", 100m, 5);

            #region User-Defined Delegate

            //Console.WriteLine(OrderService.CalculateOrderPrice1(order, OrderService.CalculateTotal));
            //Console.WriteLine(OrderService.CalculateOrderPrice1(order, OrderService.CalculateTotalWithDiscount));

            #endregion

            #region Func Delegate

            //Lambda Expression
            //Console.WriteLine(OrderService.CalculateOrderPrice2(order, x => x.Price * x.Quantity));
            //Console.WriteLine(OrderService.CalculateOrderPrice2(order, x => (x.Price * x.Quantity) * 0.90m));

            ////Func Delegate
            //Console.WriteLine(OrderService.CalculateOrderPrice2(order, OrderService.CalculateTotal));
            //Console.WriteLine(OrderService.CalculateOrderPrice2(order, OrderService.CalculateTotalWithDiscount));

            #endregion

            #region Predicate Delegate

            //Console.WriteLine(OrderService.ValidateOrder(order, order => order.Quantity > 0));
            //Console.WriteLine(OrderService.ValidateOrder(order, order => order.Price > 0));
            //Console.WriteLine(OrderService.ValidateOrder(order, order => order.CustomerName is not null));

            #endregion

            #region Action Delegate

            //Print Order Info
            //Action<Order> printInfo = order => Console.WriteLine($"[Order Info] Id: {order.Id}, Customer Name: {order.CustomerName}, " +
            //                                                     $"Price: {order.Price}, Quantity: {order.Quantity}");
            //OrderService.ProcessOrder(order, printInfo);

            ////Print Confirmation Message
            //Action<Order> confirmationMesage = order => Console.WriteLine($"Confirmation sent to {order.CustomerName}");
            //OrderService.ProcessOrder(order, confirmationMesage);

            ////Print Audit Message (Another way)
            //OrderService.ProcessOrder(order, order => Console.WriteLine($"Audit: Order {order.Id} was processed"));
            #endregion

            #region Events

            //static void Handler1(Order order)
            //{
            //    Console.WriteLine($"Order {order.Id} Completed");
            //}

            //static void Handler2(Order order)
            //{
            //    Console.WriteLine($"Sending notification for Order {order.Id} ");
            //}

            //static void Handler3(Order order)
            //{
            //    Console.WriteLine($"Writing audit for Order {order.Id}");
            //}

            //OrderService.orderProcessed += Handler1;
            //OrderService.orderProcessed += Handler2;
            //OrderService.orderProcessed += Handler3;

            //OrderService.orderProcessed -= Handler1;

            //OrderService.ProcessOrder(order);


            #endregion

            #region Commented Question  
            #region Q1
            // PriceCalculator is a user-defined delegate.
            // We explicitly create it ourselves:
            //
            // public delegate decimal PriceCalculator(Order order);
            //
            // Func<Order, decimal> is a built-in generic delegate provided by C#.
            //
            // Both represent a method that:
            // - receives an Order
            // - returns a decimal
            //
            // The main difference is that PriceCalculator has a custom name
            // and must be declared by us, while Func<Order, decimal> is already
            // provided by .NET.
            //
            // Therefore, Func<Order, decimal> avoids creating a custom delegate
            // when a standard delegate signature is sufficient.
            #endregion

            #region Q2
            // Action<Order> represents a method that receives an Order
            // and does not return a value.
            //
            // Func<Order, decimal> represents a method that receives an Order
            // and returns a decimal.
            //
            // Example:
            //
            // Action<Order>:
            // order => Console.WriteLine(order.Id);
            //
            // Func<Order, decimal>:
            // order => order.Price * order.Quantity;
            //
            // Therefore:
            // Action<T>     -> performs an action, returns void.
            // Func<T, TResult> -> calculates/returns a TResult.
            #endregion

            #region Q3
            // Predicate<T> always returns bool because it is designed
            // to represent a condition or validation rule.
            //
            // For example:
            //
            // Predicate<Order> rule = order => order.Quantity > 0;
            //
            // The result is either:
            // true  -> the order satisfies the rule.
            // false -> the order does not satisfy the rule.
            //
            // It is designed for problems such as validation,
            // filtering, searching, and checking conditions.
            #endregion

            #region Q4
            // A delegate is an object that can reference one or more methods
            // and can be directly invoked.
            //
            // An event is a controlled way of exposing a delegate so that
            // outside code can subscribe and unsubscribe from notifications,
            // but normally cannot directly invoke the event.
            //
            // Delegate:
            // - Represents a method/methods.
            // - Can be invoked by code that has access to it.
            //
            // Event:
            // - Used mainly for notifications.
            // - Allows external code to subscribe/unsubscribe.
            // - The class that owns the event controls when it is raised.
            #endregion

            #region Q5
            // External code normally cannot invoke an event because events
            // are designed so that only the class that declares the event
            // can raise/invoke it.
            //
            // External classes can do:
            //
            // orderService.OrderProcessed += Handler;
            //
            // and:
            //
            // orderService.OrderProcessed -= Handler;
            //
            // But they cannot normally do:
            //
            // orderService.OrderProcessed(order);
            //
            // This protects the event owner from having external code
            // trigger the event at an inappropriate time.
            #endregion

            #region Q6
            // When multiple handlers subscribe to the same event,
            // the event has multicast behavior.
            //
            // When the event is raised, all subscribed handlers
            // are executed one after another.
            //
            // Example:
            //
            // OrderProcessed += Handler1;
            // OrderProcessed += Handler2;
            // OrderProcessed += Handler3;
            //
            // When:
            //
            // OrderProcessed?.Invoke(order);
            //
            // is executed:
            //
            // Handler1 -> executes
            // Handler2 -> executes
            // Handler3 -> executes
            //
            // This is called multicast behavior.
            #endregion

            #region Q7
            // orderService.OrderProcessed += HandleOrderProcessed;
            //
            // OrderProcessed
            // ----------------
            // This is the event that we want to subscribe to.
            //
            // +=
            // --
            // This means "subscribe/add a handler to the event".
            //
            // HandleOrderProcessed
            // --------------------
            // This is the method that will be called when
            // the OrderProcessed event is raised.
            //
            // So the complete statement means:
            //
            // "When OrderProcessed happens, execute
            // HandleOrderProcessed."
            #endregion

            #region Q8
            // Action<Order> is simply a delegate type.
            //
            // For example:
            //
            // Action<Order> action;
            //
            // Code that has access to the delegate may be able to
            // invoke it directly.
            //
            // event Action<Order> is an event that uses Action<Order>
            // as its underlying delegate type.
            //
            // The important difference is access control.
            //
            // With an event:
            //
            // public event Action<Order> OrderProcessed;
            //
            // External code can:
            //
            // OrderProcessed += Handler;
            // OrderProcessed -= Handler;
            //
            // But external code cannot normally raise the event.
            //
            // Only the class that owns the event should raise it:
            //
            // OrderProcessed?.Invoke(order);
            //
            // Therefore, we use an event when we want to provide
            // a notification mechanism while preventing outside code
            // from raising the notification.
            //
            // In short:
            //
            // Action<Order>
            // = delegate representing a behavior.
            //
            // event Action<Order>
            // = notification mechanism with controlled subscription
            //   and controlled invocation.
            #endregion
            #endregion

            #endregion

        }
    }
}
