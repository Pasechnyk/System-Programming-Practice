using System;

// Task - Create array C with combined elements from array A and B using stockalloc method.

namespace UnsafeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // using unsafe block
            unsafe
            {
                int sizeM, sizeN;

                // set arrays size
                Console.WriteLine("Enter the size of Array M: ");
                sizeM = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the size of Array N: ");
                sizeN = int.Parse(Console.ReadLine());

                int* arrA = stackalloc int[sizeM];
                int* arrB = stackalloc int[sizeN];

                // populate arrays
                Console.WriteLine("Enter the Elements of the Array M:");
                for (int i = 0; i < sizeM; i++)
                {
                    arrA[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter the Elements of the Array M:");
                for (int i = 0; i < sizeN; i++)
                {
                    arrB[i] = int.Parse(Console.ReadLine());
                }


                int sizeC = sizeM + sizeN;
                int* arrC = stackalloc int[sizeC];

                // setting array C
                for (int i = 0; i < sizeM; i++)
                {
                    for (int j = 0; j < sizeN; j++)
                    {
                        arrC[sizeC] = arrA[i] + arrB[j];
                    }
                }

                Console.WriteLine("Array C: ");

                for (int i = 0; i < sizeC; i++)
                {
                    Console.Write(arrC[i]);
                }
            }
        }
    }
}
