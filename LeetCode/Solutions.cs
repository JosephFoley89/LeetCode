using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
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

        //08-18-2025
        //https://leetcode.com/problems/24-game/description/?envType=daily-question&envId=2025-08-18
        //Write a function that given four numbers (between 1 and 9) that can be added, subtracted, multiplied
        //divided to reach 24 in some combination. Return a boolean indicating whether or not it's
        //possible given the four numbers. This is a particularly annoying and tedious problem that I couldn't solve.
        //Credit to user daulat_309 for helping me keep the streak alive.
        //https://leetcode.com/problems/24-game/solutions/7093770/24-game-o-1-java-c-c-c-python3-javascript-go

        public bool CanBeMathedTo24(int[] numbers) {
            List<double> nums = new List<double>();

            foreach (int n in numbers) {
                nums.Add((double)n);
            }

            return DepthFirst(nums);
        }

        public bool DepthFirst(List<double> nums) {
            const double EPSILON = 1e-6;

            if (nums.Count == 1) {
                return Math.Abs(nums[0] - 24) < EPSILON;
            }

            for (int i = 0; i < nums.Count; i++) {
                for (int j = 0; j < nums.Count; j++) {
                    if (i == j) {
                        continue;
                    }

                    List<double> next = new List<double>();

                    for (int k = 0; k < nums.Count; k++) {
                        if (k != i && k != j) {
                            next.Add(nums[k]);
                        }
                    }

                    foreach (double val in Computations(nums[i], nums[j], EPSILON)) {
                        next.Add(val);

                        if (DepthFirst(next)) {
                            return true;
                        }

                        next.RemoveAt(next.Count - 1);
                    }
                }
            }

            return false;
        }

        public List<double> Computations(double x, double y, double EPSILON) {
            List<double> computations = new List<double>();
            computations.Add(x + y);
            computations.Add(x - y);
            computations.Add(y - x);
            computations.Add(x * y);
            
            if (Math.Abs(x) > EPSILON)
                computations.Add(x / y);

            if (Math.Abs(y) > EPSILON)
                computations.Add(y / x);

            return computations;
        }

        //08-19-2025
        //https://leetcode.com/problems/number-of-zero-filled-subarrays/?envType=daily-question&envId=2025-08-19
        //Write a function that returns the total number of subarrays completely populated with zeroes. A subarray
        //is a slice of an array that is 1..array.length-1 in length. My implementation will be a bit more generic
        //than is required on LeetCode.

        public long TotalNumberOfXSubarrays(int[] numbers, int x) {
            long total = 0, sequence = 0;

            foreach (int n in numbers) {
                if (n == x) {
                    sequence++;
                    total += sequence;
                } else {
                    sequence = 0;
                }
            }

            return total;
        }

    }
}
