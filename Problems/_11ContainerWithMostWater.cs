using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _11ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;

            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int width = right - left;
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * width);
                if (height[left ] <=  height[right ])
                {
                    left++;

                }
                else
                {
                    right--;
                }

            }
            return maxArea;
        }
    }
}
