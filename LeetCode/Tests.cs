using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LeetCode;

namespace LeetCode {
    internal class Tests {
        private static Solution solution;

        public Tests() {
            solution = new Solution();
        }

        public void TestPowerOfX() {
            const int power = 4;

            for (int i = 0; i < 100; i++) {
                solution.IsPowerOfX(i, power);   
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
                solution.MaximumPositiveInteger(i);
            }
        }
    }
}
