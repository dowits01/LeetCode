using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _7ReverseInteger
    {
        public static int ReverseInteger(int x)
        {
            int result = 0;

            while (x !=0 )
            {
                int remainder = x % 10;
                if(result > int.MaxValue/10)
                {
                    return 0;
                }
                if( result < int.MinValue/10)
                {
                    return 0;
                }

                result = result * 10 + remainder;
                x = x / 10;
            }


            return result;
        }
    }
}
