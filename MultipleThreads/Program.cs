using System;
using System.IO;
using System.Threading;
using System.Windows;

// Task - Count words, lines and punctuation in chosen files using multiple threads

namespace MultipleThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path you want to access: ");
            string filePath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine("No suitable file path was given.");
                return;
            }

            Property property = new Property();
            var files = Directory.GetFiles(filePath);

            foreach (var f in files)
            {
                string text = File.ReadAllText(f);
                Thread thread = new Thread(ThreadAnalyse);

                thread.IsBackground = true;
                thread.Start();
            }

            Console.WriteLine($"Statistics:" +
                $"\nWords - {property.Words}" +
                $"\nLines - {property.Lines}" +
                $"\nPunctuation - {property.Punctuation}");
        }

        static void ThreadAnalyse(object prop)
        {
            string text = ((object[])prop)[0].ToString();

            var property = ((object[])prop)[0] as Property;

            foreach (var word in text.Split(' '))
            {
                foreach (var symb in word)
                {
                    if (char.IsWhiteSpace(symb))
                        Interlocked.Increment(ref property.Words);

                    else if (char.IsWhiteSpace(symb))
                        Interlocked.Increment(ref property.Lines);

                    else if (char.IsPunctuation(symb))
                        Interlocked.Increment(ref property.Punctuation);
                }
            }
        }
    }
}
