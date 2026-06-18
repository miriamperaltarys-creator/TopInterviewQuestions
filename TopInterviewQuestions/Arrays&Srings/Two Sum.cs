using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TopInterviewQuestions.Arrays_Srings
{
     /* Given an array of integers nums and an integer target, return indices of the

         two numbers such that they add up to target.

         You may assume that each input would have exactly one solution, and you may

         not use the same element twice.

         You can return the answer in any order.

         Input: nums = [2,7,11,15], target = 9

         Output: [0,1]

         Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

         Example 2:
         Input: nums = [3,2,4], target = 6
         Output: [1,2]

         Example 3:

         Input: nums = [3,3], target = 6

         Output: [0,1] 
     */

     

    public class Two_Sum
    {
        /// <summary>
            // Time Complexity: O(n²)
            // The algorithm uses two nested loops to compare each pair of elements.
            // In the worst case, it checks all possible pairs.

            // Space Complexity: O(1)
            // The algorithm uses only a few extra variables regardless of the input size.
        /// </summary>
        public void   Sum()
        {
            Console.WriteLine("*---------Welcome to :  TWO SUM------------*");
            Console.WriteLine("Enter the number of elements for the array");
            int numElementsArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the target number");
            int numTarget = Convert.ToInt32(Console.ReadLine());
            int[] arrayNums = new int[numElementsArray];

            //Add elements to the array 
            for (int i = 0; i < numElementsArray; i++)
            {
                Console.WriteLine($"Enter the number for the position {i}");
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
            }

            //

            int numauxiliar = 0;
            int sum = 0;
            for (int j = 0; j < arrayNums.Length; j++) // O(N)
            {
                for (int k = j + 1; k < arrayNums.Length; k++) // O(N)
                {
                    sum = arrayNums[j] + arrayNums[k];

                    if (sum == numTarget) { 
                        Console.WriteLine($"Los índices son: [{j}, {k}]");
                        return;
                    }
                }
            }
    }
}
}
