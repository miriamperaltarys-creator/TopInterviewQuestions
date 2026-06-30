using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterviewQuestions.Arrays_Srings
{
    public class MoveZerosVFinal
    {
        public void MoveZerosToFinal()
        {
            // Input: nums = [0,1,0,3,12]

            // Output: [1,3,12,0,0]

            // Input: nums = [0]

            // Output: [0]

            Console.WriteLine("Enter the number of elements for the array.");
            int numElements = Convert.ToInt32(Console.ReadLine());

            int[] arrayNumbers = new int[numElements];


            string auxiliar = String.Empty;
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine($"Enter the number  for the position{i}");
                int number = Convert.ToInt32(Console.ReadLine());
                arrayNumbers[i] = number;
            }

            //int[] arrayNumbers = {0,1,0,3,12 };
            int writeIndex = 0;
            for (int l = 0; l < arrayNumbers.Length; l++)  //O(N)
            {

                if (arrayNumbers[l] != 0)
                {
                    arrayNumbers[writeIndex] = arrayNumbers[l];
                    writeIndex++;
                }

            }
            for (int i = writeIndex; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = 0;
            }
           

            Console.WriteLine("----------------PRINT ARRRAY------------------");
         
            for (int l = 0; l < arrayNumbers.Length; l++)
            {
                Console.WriteLine(arrayNumbers[l]);
            }
          

        }
    }
}
