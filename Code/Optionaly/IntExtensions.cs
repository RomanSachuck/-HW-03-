using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class IntExtensions
    {
        public static bool IsNegative(this int number)
        {
            if (number < 0)
                return true;
            else
                return false;
        }
    }
}
