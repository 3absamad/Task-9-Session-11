using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_Session_11
{
    public class BookFunctions
    {

        public static string GetTitle(Book B)
        {
            return B?.Title ?? "Unknown";
        }

        public static string GetAuthors(Book B) 
        {
            if (B?.Authors == null || B.Authors.Length == 0)
                return "No Authors";
            return string.Join(", ", B.Authors);
        } 

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
