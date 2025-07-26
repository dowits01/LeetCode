using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _3
    {
      public static int LengthOfLongestSubstring(string s)
        {
            // Leet Code number 3
            int left = 0;
            int right = 0;
            int maxLength = 0;

            HashSet<char> charSet = new();

            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }

    }
}
