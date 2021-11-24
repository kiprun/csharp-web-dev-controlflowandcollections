using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "I would not, could not, in a box. I would not, could not with a fox. " +
                         "I will not eat them in a house. I will not eat them with a mouse.";
            //string[] words = msg.Split(" ");// makes each word it's own array
            string[] words = msg.Split(". ");//makes a new array at each .
            Console.WriteLine(string.Join("\n", words)); //joins each array with a , in between each
            }
    }
}
