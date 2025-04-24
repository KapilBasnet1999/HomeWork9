// Written by Kapil Basnet
// April 23, 2025

using System;
using System.Collections.Generic;

namespace HomeWork9
{
    public class HomeWork9
    {
        // Problem 1: Move Zeroes
        public void MoveZeroes(int[] nums)
        {
            int insertPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertPos] = nums[i];
                    insertPos++;
                }
            }
            while (insertPos < nums.Length)
            {
                nums[insertPos] = 0;
                insertPos++;
            }
        }

        // Problem 2: Length of Last Word
        public int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            string[] words = s.Split(' ');
            return words[words.Length - 1].Length;
        }

        // Problem 3: Reverse String
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
        }

        // Problem 4: Majority Element
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }
            return candidate;
        }

        // Problem 5: Happy Number
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = SumOfSquares(n);
            }
            return n == 1;
        }

        private int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }
    }
}
