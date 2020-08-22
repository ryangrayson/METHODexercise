using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is your name?
            //What is a movie you like?
            //What is a band that you like?
            //What city do you live in?
            //To get acceptable input, you must guide that user

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey there, {userName}! What is a band that you like?");
            var likedBand = Console.ReadLine();

            Console.WriteLine($"Great! I like {likedBand} as well! Can you tell me a movie you like?");
            var likedMovie = Console.ReadLine();

            Console.WriteLine($"{likedMovie}?! I like that one too, where do you stay at?");
            var dwelling = Console.ReadLine();

            Console.WriteLine($"Yikes. {dwelling} sucks.");


        }
    }
}
