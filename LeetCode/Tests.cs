using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LeetCode;

namespace LeetCode {
    internal class Tests {
        Solution solution;

        public Tests() {
            solution = new Solution();
        }

        public void TestPowerOfX() {
            const int power = 4;

            for (int i = 0; i < 100; i++) {
                solution.IsPowerOfX(i, power);   
            }
        }
    }
}
