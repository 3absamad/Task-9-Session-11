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

            #endregion

            #endregion

        }
    }
}
