using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Day23Tasks
{
    internal static class IntExtention
    {
        public static bool IsOdd(this int num)
        {
            if (num%2==0) return false;
            return true;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }
    }
}
