using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15
{
    internal static class Sort
    {
        //List<int> Arr {  get; set; }
        static private int Val(int num)
        {
            num = Math.Abs(num);
            int val = 0;
            while (num > 0)
            {
                val += num % 10;
                num /= 10;
            }
            return val;
        }
        static private int Compare(int a, int b)
        {
            return Val(a).CompareTo(Val(b));
        }

        static public void MySort(ref List<int> arr, bool reverse = false)
        {
            arr.Sort((a, b) => (Compare(a, b)));
            if (reverse) { arr.Reverse(); }
        }
    }
}
