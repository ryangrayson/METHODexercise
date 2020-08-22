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
            //To get acceptable input, you must guide the user

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey there, {userName}! What is a band that you like?");
            var likedBand = Console.ReadLine();

            Console.WriteLine($"Great! {likedBand} ROCKS SO HARD! Can you tell me a movie you like?");
            var likedMovie = Console.ReadLine();

            Console.WriteLine($"{likedMovie}?! {userName}, you have really great taste. I like that one a lot too, where do you stay at?");
            var dwelling = Console.ReadLine();

            Console.WriteLine($"Yikes. {dwelling} sucks.");


        }
    }
}
