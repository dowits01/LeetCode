using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ReverseWords151
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            Array.Reverse(words);
            
            return string.Join(" ", words);
        }
    }
}
