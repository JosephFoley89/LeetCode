using System.Text;

namespace LeetCode {
    internal class Solution {
        //08-15-2025
        //https://leetcode.com/problems/power-of-four/?envType=daily-question&envId=2025-08-15
        //Write a function that determines if a given number n is a power of 4.
        //This function could be further generalized to determine if n is a power of x.

        public void IsPowerOfFour(int n) {
            Console.WriteLine(
                n != 0 && 
                Math.Floor(Math.Log(n) / Math.Log(4)) == 
                Math.Ceiling(Math.Log(n) / Math.Log(4))
            );
        }

        public void IsPowerOfX(int n, int x) {
            Console.WriteLine(
                $"Is {n} a power of {x}? " +
                $"{n != 0 && Math.Floor(Math.Log(n) / Math.Log(x)) == 
                Math.Ceiling(Math.Log(n) / Math.Log(x))}"
            );
        }

        //08-16-2025
        //https://leetcode.com/problems/maximum-69-number/?envType=daily-question&envId=2025-08-16
        //Write a function that given a positive 9 and 6 integers returns the highest possible value with a single 6-9 flip

        public void MaximumPositiveInteger(int num) {
            char[] digits = num.ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++) {
                if (digits[i] == '6') {
                    digits[i] = '9';
                    break;
                }
            }

            Console.WriteLine(Int32.Parse(new String(digits)));
        }
    }
}
