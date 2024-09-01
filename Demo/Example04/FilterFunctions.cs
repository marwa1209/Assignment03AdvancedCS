using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example04
{
    internal class FilterFunctions
    {
        public static bool EvenFilter(int X)
        {
            return X % 2 == 0;
        }
        public static bool OdddFilter(int X)
        {
            return X % 2 == 1;
        }
        public static bool BySTenFilter(int X)
        {
            return X % 10 == 0;
        }

    }
}
