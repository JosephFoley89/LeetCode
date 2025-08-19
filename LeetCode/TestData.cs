using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    internal class TestData {
        public List<int[]> GenerateIntegerArrayList(int arrayLength, int numberOfArrays, int randomMin = 0, int randomMax = 1000) {
            List<int[]> testData = new List<int[]>();
            Random random = new Random();

            for (int i = 0; i < numberOfArrays; i++) {
                int[] data = new int[arrayLength];

                for (int j = 0; j < arrayLength; j++) {
                    data[j] = random.Next(randomMin, randomMax);
                }

                testData.Add(data);
            }

            return testData;
        }
    }
}
