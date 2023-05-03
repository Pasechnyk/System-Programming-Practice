using System;
using System.Linq;
using System.Threading.Tasks;

// Task - Create parrallel tasks with class Task

namespace ParallelTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;

            // Task 1 

            Task task1 = new Task(() => Console.WriteLine($"Task 1 Time - {currentTime}"));
            task1.Start();

            // automatic start
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine($"Task 2 Time - {currentTime}"));
            Task task3 = Task.Run(() => { Console.WriteLine($"Task 3 Time - {currentTime}"); });


            // Task 2 - 3

            static void ShowPrimeNumbers()
            {
                bool isPrime = true;

                for (int i = 2; i <= 1000; i++)
                {
                    for (int j = 2; j <= 1000; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.Write(" " + i);
                    }
                    isPrime = true;
                }
                Console.WriteLine("Prime Numbers - ");
            }

            Task task4 = new Task(ShowPrimeNumbers);
            task4.Start();
            task4.Wait();

            static int CountPrimeNumbers(int start, int end)
            {
                int counter = 0;
                if (start >= end && start < 0)
                {
                    Console.WriteLine("Incorrect values!");
                }

                bool isPrime = true;

                for (int i = start; i <= end; i++)
                {
                    for (int j = 2; j <= 1000; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        counter++;
                    }
                    isPrime = true;
                }
                return counter;
            }

            Task task5 = Task.Run(() => { Console.WriteLine(CountPrimeNumbers(1, 500)); });
            task5.Start();
            task4.Wait();


            // Task 4

            int[] numbers = new int[]{ 5, 9, 8, 1, 6, 3, 7, 2, 4 };

            Task task6 = new Task(() => Console.WriteLine($"Min: {numbers.Min()}"));
            task6.Start();
            task6.Wait();
            Task task7 = new Task(() => Console.WriteLine($"Max: {numbers.Max()}"));
            task7.Start();
            task7.Wait();
            Task task8 = new Task(() => Console.WriteLine($"Avg: {numbers.Average()}"));
            task8.Start();
            task8.Wait();
            Task task9 = new Task(() => Console.WriteLine($"Sum: {numbers.Sum()}"));
            task9.Start();
            task9.Wait();

            // Task 5

            static void DistinctNumbers(int[] num)
            {
                num.Distinct();
            }
            static void SortNumbers(int[] num)
            {
                Array.Sort(num);
            }

            Task task10 = new Task(() => DistinctNumbers(numbers));
            task10.Start();
            Task task11 = task10.ContinueWith(task => SortNumbers(numbers));
            task11.Wait();

        }
    }
}
