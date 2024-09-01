using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02_Delegate
{
    internal class ComareFunction
    {
        public static bool GreaterThan(int X , int Y)
        {
            return X > Y;
        }
        public static bool LessThan(int X, int Y)
        {
            return X < Y;
        }     
        public static bool SortStringAsc(string X, string Y)
        {
            return X?.Length > Y?.Length;
        }      
        public static bool SortStringDesc(string X, string Y)
        {
            return X?.Length < Y?.Length;
        }
    }
}
