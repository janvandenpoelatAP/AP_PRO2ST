using System;

namespace OefeningDebugging4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;


            Console.Write("\n\nFind the second largest element in an array :\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input the size of array : ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];

            /* Stored values into the array*/
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* find location of the largest element in the array */
            var lrg = 0;
            int j = 0;
            for (i = 0; i < n; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            /* ignore the largest element and find the 2nd largest element in the array */
            var lrg2nd = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the largest element */
                }
                else
                {
                    if (lrg2nd > arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
            Console.ReadLine();
        }
    }
}
