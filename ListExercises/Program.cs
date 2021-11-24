using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0) //finds each even number
                { 
                    sum += i ; //adds each even number and stores in sum
                }
            }
            Console.WriteLine(sum);*/

            List<string> words = new List<string> { "Me", "Robert", "Apple", "Two", "Neat", "Blues" };
            foreach (string word in words)
            {
                Console.WriteLine("What's the length of your words for your word serach?");
                int lengthofWords = int.Parse(Console.ReadLine());
                if (word.Length >= lengthofWords)// checks the length of each word and returns it
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
