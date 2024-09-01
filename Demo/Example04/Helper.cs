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
        public static List<int> OddNumbers(List<int> Numbers , FilterFuncDelegate<int,bool> FilterList)
        {
            List<int> Result = new List<int>();
            if (Numbers != null)
            {
               int length = Numbers.Count;
                for (int i = 0;  i  < length; i ++)
                {
                    if (FilterList.Invoke(Numbers[i])) 
                        Result.Add(Numbers[i]);
                }
            }
            return Result;
        }
    }
}
