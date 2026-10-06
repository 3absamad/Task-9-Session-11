using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_Session_11
{
    public class LibraryEngine
    {
        public delegate string BookFunction(Book B);

        public static void ProcessBooks(List<Book> bList, BookFunction Fptr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(Fptr(b));
            }
        }

        //public static void ProcessBooks(List<Book> bList, Func<Book, string> Fptr)
        //{
        //    foreach (Book b in bList)
        //    {
        //        Console.WriteLine(Fptr(b));
        //    }
        //}
    }
}
