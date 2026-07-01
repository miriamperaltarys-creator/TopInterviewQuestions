using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterviewQuestions.Arrays_Srings
{
    public class SecondLargestElementArray
    {
        public void SecongLElement()
        {
            int[] arr = { 10, 5, 10 };
            int? numFirs = null;
            int? numSecond = null;
            for (int i = 0; i < arr.Length; i++)
            {
                
                    numFirs = arr[i];
                    numSecond = arr[i];
                
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"numFirs {numFirs}");
                Console.WriteLine($" numSecond {numSecond}");
                Console.WriteLine($"arr[i] {arr[i]}");

                if (arr[i] > numFirs)
                {
                    numSecond = numFirs;
                    numFirs = arr[i];
                }

                if (numSecond != null &&  arr[i] > numSecond && arr[i] < numFirs) 
                {
                    numSecond = arr[i];
                    
                }
            }

            if (numFirs > numSecond)
            {
                Console.WriteLine($"The second largest element is 5: {numSecond}");
                Console.WriteLine($" The largest element of the array is {numFirs} and the second largest element is {numSecond}");
            }
            else
            {
                Console.WriteLine($"The second largest does not exist");
                Console.WriteLine($"Largest element of the array is: {numFirs} there is no second largest element");
            }

           
        }

        public void SecongLElementPrueba()
        {
            int[] arr = { 5, 100, 4 };
            int num = 0;
            int k = 0;
            int numSecond = 0;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                k++;

                if (k < arr.Length)
                {
                    Console.WriteLine("i :" + i);
                    Console.WriteLine("array[i] :" + arr[i]);
                    Console.WriteLine("array[k] :" + arr[k]);
                    Console.WriteLine("num :" + num);
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    if (arr[i] < arr[k] && num < arr[k])
                    {

                        num = arr[k];

                    }
                    else if (arr[i] > arr[k] && num < arr[i])
                    {

                        num = arr[i];

                    }

                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
                j++;

                if (j < arr.Length && (arr[i] != num && arr[j] != num))
                {
                    Console.WriteLine("i :" + i);
                    Console.WriteLine("array[i] :" + arr[i]);
                    Console.WriteLine("array[j] :" + arr[j]);
                    Console.WriteLine("num :" + num);
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    if (arr[i] < arr[j] && numSecond < arr[j])
                    {

                        numSecond = arr[j];

                    }
                    else if (arr[i] > arr[j] && numSecond < arr[i])
                    {

                        numSecond = arr[i];

                    }

                }
            }

            if (numSecond != 0)
            {

                Console.WriteLine($"The second largest element is: {numSecond}. ");
            }
            else
            {
                Console.WriteLine("The second largest does not exist.");
            }



            //Console.WriteLine("Primer Numero más grande" + num);

        }

    }
}
