using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03AdvancedCS.part01
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            if (B is null)
            {
                return "Not Found";
            }

            return $"Title: {B.Title}";
        }

        public static string GetAuthors(Book B)
        {
            if (B is null)
            {
                return "Not Found";
            }
            StringBuilder sb = new StringBuilder(B.Authors[0]);

            for (int i = 1; i < B.Authors.Length; i++)
            {
                sb.Append(", ");
                sb.Append(B.Authors[i]);
            }

            return $"Authors: {sb}";
        }

        public static string GetPrice(Book B)
        {
            if (B is null)
            {
                return "Not Found";
            }

            return $"Price: {B.Price}";
        }

    }
}
