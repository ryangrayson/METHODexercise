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

            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");




            Console.WriteLine("Good day, human. Please, tell me about yourself!");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");

            Console.WriteLine("What is your name?");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            var userName = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine($"Hey there, {userName}! What is a band that you like?");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            var likedBand = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");






            Console.WriteLine($"Great! {likedBand} ROCKS SO HARD! Can you tell me a movie you like?");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            var likedMovie = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");


            Console.WriteLine($"{likedMovie}?! {userName}, you have really great taste. \nI like that one a lot too.\nWhere do you stay at?");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");


            var dwelling = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine($"Yikes. {dwelling} sucks.");


            //Add some if/else statement to see if they'd like to see what i've learned about them

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine($"Thanks, {userName}! Here is what I've learned about you:");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");




            Console.WriteLine($"You're name is {userName}");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine($"You enjoy listening to {likedBand}");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine($"You like the movie {likedMovie}");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine($"You live in {dwelling}");







            


        }
    }
}
