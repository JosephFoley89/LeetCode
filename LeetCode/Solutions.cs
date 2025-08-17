using System.Text;

namespace LeetCode {
    internal class Solution {
        //08-15-2025
        //https://leetcode.com/problems/power-of-four/?envType=daily-question&envId=2025-08-15
        //Write a function that determines if a given number n is a power of 4.
        //This function could be further generalized to determine if n is a power of x.

        public bool IsPowerOfFour(int n) {
            return 
                n != 0 && 
                Math.Floor(Math.Log(n) / Math.Log(4)) == 
                Math.Ceiling(Math.Log(n) / Math.Log(4));
        }

        public bool IsPowerOfX(int n, int x) {
            return 
                n != 0 && Math.Floor(Math.Log(n) / Math.Log(x)) == 
                Math.Ceiling(Math.Log(n) / Math.Log(x));
        }

        //08-16-2025
        //https://leetcode.com/problems/maximum-69-number/?envType=daily-question&envId=2025-08-16
        //Write a function that given a positive 9 and 6 integers returns the highest possible value with a single 6-9 flip.

        public int MaximumPositiveInteger(int num) {
            char[] digits = num.ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++) {
                if (digits[i] == '6') {
                    digits[i] = '9';
                    break;
                }
            }

            return Int32.Parse(new String(digits));
        }

        //08-17-2025
        //https://leetcode.com/problems/new-21-game/?envType=daily-question&envId=2025-08-17
        //Write a function that returns the probability that the player receives exactly k points.
        //The rules of the game are as follows: The player starts with 0 points and draws n point(s) while they have
        //less than k points. When the player draws they are randomly given cards with values in the range of [1..maxPts].

        public double NewTwentyOneGame(int n, int k, int maxPts) {
            if (k == 0 || n >= k + maxPts) {
                return 1.0;
            }

            double[] dp = new double[n + 1];
            double windowSum = 1.0;
            double result = 0.0;

            dp[0] = 1.0;

            for (int i = 1; i < n + 1; i++) {
                dp[i] = windowSum / maxPts;
                
                if (i < k) {
                    windowSum += dp[i];
                } else {
                    result += dp[i];
                }

                if (i - maxPts > -1) {
                    windowSum -= dp[i - maxPts];
                }
            }

            return result;
        }
    }
}
