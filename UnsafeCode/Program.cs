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
                Console.WriteLine("Enter the size of Array A: ");
                sizeM = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the size of Array B: ");
                sizeN = int.Parse(Console.ReadLine());

                int* arrA = stackalloc int[sizeM];
                int* arrB = stackalloc int[sizeN];

                // populate arrays
                Console.WriteLine("Enter the elements of Array A:");
                for (int i = 0; i < sizeM; i++)
                {
                    arrA[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter the elements of Array B:");
                for (int i = 0; i < sizeN; i++)
                {
                    arrB[i] = int.Parse(Console.ReadLine());
                }

                // setting array C size
                int sizeC = 0;
                for (int i = 0; i < sizeM; i++)
                {
                    int count = 1;
                    for (int j = 0; j < i; j++)
                    {
                        if (arrA[i] == arrA[j])
                        {
                            ++count;
                        }
                    }
                    for (int j = 0; count != 0 && j < sizeN; j++)
                    {
                        if (arrB[i] == arrB[j])
                        {
                            --count;
                        }
                    }
                    if (count == 0)
                    {
                        ++sizeC;
                    }
                }

                // array C output
                int* arrC = stackalloc int[sizeC];
                Console.WriteLine("Array C: " + *arrC);
            }
        }
    }
}
