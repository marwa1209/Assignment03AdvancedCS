using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example04
{
    public delegate bool FilterFuncDelegate<in T, out TResult>(T X);
    internal static class Helper<T>
    {
        public static List<T> Elemsnts(List<T> Numbers , FilterFuncDelegate<T,bool> FilterList)
        {
            List<T> Result = new List<T>();
            if (Numbers != null && FilterList is not null)
            {
               int length = Numbers.Count;
                for (int i = 0;  i  < length; i ++)
                {
                    if (FilterList(Numbers[i])) 
                        Result.Add(Numbers[i]);
                }
            }
            return Result;
        }
    }
}
