using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RemoveDup26
    {
        public int RemoveDuplicates(int[] num)
        {
            if(num.Length == 0) return 0;

            int uniqueIndex = 1;

            for(int i = 1; i < num.Length; i++)
            {
                if (num[i] != num[i - 1])
                {
                    num[uniqueIndex] = num[i];
                    uniqueIndex++;
                }
            }
            return uniqueIndex;
        }
    }
}
