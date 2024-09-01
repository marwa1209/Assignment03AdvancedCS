using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02_Delegate
{
    public delegate bool CompareFuncDelegate <T>(T X ,T Y);
    internal class SotingAlgorithm<T>
    {
        #region non-generic
        //public static void BubbleSort(int[] arr ,CompareFuncDelegate CompareFunc)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (CompareFunc.Invoke(arr[j] , arr[j + 1])) { Swap(ref arr[j],ref arr[j + 1]); }
        //            }
        //        }
        //    }
        //} 

        //public static void BubbleSortDesc(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] < arr[j + 1]) { Swap(ref arr[j], ref arr[j + 1]); }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Generic
        public static void BubbleSort(T[] arr, CompareFuncDelegate<T> CompareFunc)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (CompareFunc.Invoke(arr[j], arr[j + 1])) { Swap(ref arr[j], ref arr[j + 1]); }
                    }
                }
            }
        }
        #endregion
        private static void Swap(ref T v1, ref T v2) 
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;
        }

    }
}
