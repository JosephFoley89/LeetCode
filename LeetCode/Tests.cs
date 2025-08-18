using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LeetCode;

namespace LeetCode {
    internal class Tests {
        private readonly Solution solution;

        public Tests() {
            solution = new Solution();
        }

        public void TestPowerOfX() {
            const int power = 3;

            for (int i = 1; i < 101; i++) {
                Console.WriteLine($"{i} is a power of 4?\t{solution.IsPowerOfFour(i)}");
                Console.WriteLine($"{i} is a power of {power}?\t{solution.IsPowerOfX(i, power)}");
            }
        }

        public void TestMaximumInteger() {
            int[] data = {
                9669,
                6999,
                9996,
                9696,
                6699,
                6996
            };

            foreach (int i in data) {
                Console.WriteLine($"The maximum number after swapping 6 for 9 given {i} is: {solution.MaximumPositiveInteger(i)}.");
            }
        }

        public void TestTwentyOneGame() {
            List<int> ns = new List<int>() { 10, 6, 21 };
            List<int> ks = new List<int>() { 1, 1, 17 };
            List<int> max = new List<int>() { 10, 10, 10 };

            for (int i = 0; i < ns.Count; i++) {
                Console.WriteLine(
                    "The probability that the player has fewer than n points is: "
                    + $"{solution.NewTwentyOneGame(ns[i], ks[i], max[i]).ToString("0%")}."
                );
            }
        }

        public void TestCanBeMathedTo24() {
            List<int[]> testData = new List<int[]>();
            Random random = new Random();

            for (int i = 0; i < 25; i++) {
                int[] data = new int[] {
                    random.Next(1,9), 
                    random.Next(1,9), 
                    random.Next(1,9),
                    random.Next(1,9)
                };
                testData.Add(data);
            }

            foreach (int[] data in testData) {
                Console.WriteLine(
                    "Is there a combination of mathematical operators that can reach 24 given "
                    + $"{String.Join(",", data)}?\t{solution.CanBeMathedTo24(data)}"
                );
            }
        }
    }
}
