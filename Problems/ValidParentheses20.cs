using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ValidParentheses20
    {
        public bool Isvalid(string s)
        {
            Dictionary<char, char> matches = new();
            matches.Add('(', ')');
            matches.Add('[', ']');
            matches.Add('{', '}');

            Stack<char> stack = new();
            foreach (char c in s)
            {
                if (matches.ContainsKey(c))
                {
                    stack.Push(c);

                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char topElement = stack.Pop();
                    if (matches[topElement] != c)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
