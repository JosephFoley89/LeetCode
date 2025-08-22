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
        private TestData testData;

        public Tests() {
            solution = new Solution();
            testData = new TestData();
        }

        public void ExecutTests() {
            TestPowerOfX();
            TestMaximumInteger();
            TestTwentyOneGame();
            TestCanBeMathedTo24();
            TestTotalNumberOfXSubarrays(0);
            TestCountSquares(1);
            TestNumSubmatrices();
            TestMinimumArea();
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
            foreach (int[] d in testData.GenerateIntegerArrayList(10, 25, 1, 9)) {
                Console.WriteLine(
                    "Is there a combination of mathematical operators that can reach 24 given "
                    + $"{String.Join(",", d)}?\t{solution.CanBeMathedTo24(d)}"
                );
            }
        }

        public void TestTotalNumberOfXSubarrays(int x) {
            List<int[]> data = testData.GenerateIntegerArrayList(10, 25, 0, 9);

            foreach (int[] d in data) {
                Console.WriteLine($"Total number of {x} given {string.Join(",", d)}:\t{solution.TotalNumberOfXSubarrays(d, x)}.");
            }
        }

        public void TestCountSquares(int n) {
            List<int[][]> matrices = testData.GenerateBinaryMatrix(5, 10, 10, .55);

            foreach (int[][] matrix in matrices) {
                for (int x = 0; x < matrix.Length - 1; x++) {
                    for (int y = 0; y < matrix[x].Length - 1; y++) {
                        Console.Write($" {matrix[x][y]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"The total number of square {n}s in the above matrix is:{solution.CountSquares(matrix, n)}");
            }
        }

        public void TestNumSubmatrices() {
            List<int[][]> matrices = testData.GenerateBinaryMatrix(5, 10, 12, .55);

            foreach (int[][] matrix in matrices) {
                for (int x = 0; x < matrix.Length - 1; x++) {
                    for (int y = 0; y < matrix[x].Length - 1; y++) {
                        Console.Write($" {matrix[x][y]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"The total number of rectangular 1s in the above matrix is:{solution.NumSubMat(matrix)}");
            }
        }

        public void TestMinimumArea() {
            List<int[][]> matrices = testData.GenerateBinaryMatrix(5, 5, 5, .15);

            foreach (int[][] matrix in matrices) {
                for (int x = 0; x < matrix.Length - 1; x++) {
                    for (int y = 0; y < matrix[x].Length - 1; y++) {
                        Console.Write($" {matrix[x][y]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"The minimum area to cover all ones for the given array is {solution.MinimumArea(matrix)}");
            }

        }
    }
}
