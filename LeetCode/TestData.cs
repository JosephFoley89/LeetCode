using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    internal class TestData {
        private static Random random;

        public TestData() {
            random = new Random();
        }

        public List<int[]> GenerateIntegerArrayList(int arrayLength, int numberOfArrays, int randomMin = 0, int randomMax = 1000) {
            List<int[]> testData = new List<int[]>();

            for (int i = 0; i < numberOfArrays; i++) {
                int[] data = new int[arrayLength];

                for (int j = 0; j < arrayLength; j++) {
                    data[j] = random.Next(randomMin, randomMax);
                }

                testData.Add(data);
            }

            return testData;
        }

        public List<int[][]> GenerateMatrix(int number, int x, int y, bool isBinary = false, double oneChance = 0.33) {
            List<int[][]> matrices = new List<int[][]>();
            double chance = Math.Abs(oneChance - 1.0);

            for (int n = 0; n < number; n++) {
                int[][] matrix = new int[x][];

                for (int i = 0; i < x; i++) {
                    matrix[i] = new int[y];

                    for (int j = 0; j < y; j++) {
                        if (isBinary) {
                            matrix[i][j] = random.NextDouble() > chance ? 1 : 0;
                        } else {
                            matrix[i][j] = random.Next(0,100);
                        }
                    }
                }

                matrices.Add(matrix);
            }

            return matrices;
        }
    }
}
