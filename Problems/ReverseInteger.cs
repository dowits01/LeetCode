using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ReverseInteger
    {
        public int ReverseInt(int x)
        {
            int reversed = 0;

            while (x != 0)
            {
                int digit = x % 10; //Extract the last digit
                x /= 10; //Remove the last digit from x

                //check for potential overflow before updating 'reversed'

                if (reversed > Int32.MaxValue / 10 || (reversed == Int32.MaxValue / 10 && digit > 7))
                {
                    return 0; //overflow
                }

                if (reversed < Int32.MinValue / 10 || ( reversed == Int32.MinValue / 10 && digit < -8))
                {
                    return 0; //underflow
                }

                reversed = reversed * 10 + digit; //build the reversed number
                
            }

            return reversed;
        }
    }
}
