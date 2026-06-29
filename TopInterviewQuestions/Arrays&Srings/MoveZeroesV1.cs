using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterviewQuestions.Arrays_Srings
{
    /*
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        // Input: nums = [0,1,0,3,12]

        // Output: [1,3,12,0,0]

        // Input: nums = [0]

        // Output: [0]


     */
    public class MoveZeroesV1
    {

        public void MoveZerosToFinall()
        {
            // Input: nums = [0,1,0,3,12]

            // Output: [1,3,12,0,0]

            // Input: nums = [0]

            // Output: [0]

            Console.WriteLine("Enter the number of elements for the array.");
            int numElements = Convert.ToInt32(Console.ReadLine());

            int[]  arrayNumbers = new int[numElements];
            int[]  arrayAuxiliar = new int[numElements];
         
            string auxiliar = String.Empty;
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine($"Enter the number  for the position{i}");
                int number = Convert.ToInt32(Console.ReadLine());
                arrayNumbers[i] = number;
            }

            for (int l = 0; l < arrayNumbers.Length; l++)
            {
                
                if (arrayNumbers[l] != 0)
                {
                    auxiliar += arrayNumbers[l] + ",";
                }
                
            }
            int[] num = auxiliar.TrimEnd(',').Split(',').Select(int.Parse).ToArray();
        
            Console.WriteLine("----------------ARRAYAUXILIAR------------------");
            int contador = 0;
            for (int l = 0; l < arrayAuxiliar.Length; l++)
            {
                int tamnum = num.Length;
                
                if (contador < tamnum)
                {
                    arrayAuxiliar[l] = num[l];
                    contador++;
                }
            }
            Console.WriteLine("----------------PRINTARRRAYS------------------");
            Console.WriteLine("----------------ARRAYORIGINAL------------------");
            for (int l = 0; l < arrayNumbers.Length; l++)
            {
                Console.WriteLine(arrayNumbers[l]);
            }
            Console.WriteLine("----------------ARRAYAUXILIAR------------------");
            for (int l = 0; l < arrayAuxiliar.Length; l++)
            {
                Console.WriteLine(arrayAuxiliar[l]);
            }

        }
    }
}
