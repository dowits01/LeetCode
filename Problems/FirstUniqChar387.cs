using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class FirstUniqChar387
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] += 1; 
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            for(int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                    return i;
            }

            return -1;
        }
        
    }
}
