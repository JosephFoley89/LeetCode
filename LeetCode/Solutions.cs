using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    internal class Solution {

        //08-15-2025
        //https://leetcode.com/problems/power-of-four/?envType=daily-question&envId=2025-08-15
        //Write a function that determines if a given number n is a power of 4.
        //This function could be further generalized to determine if n is a power of x.

        public void ProblemOne(int n) {
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



    }
}
