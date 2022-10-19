using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();
        }

        static void MadLib()
        {
            Console.WriteLine($"Input dog name: ");
            var dogName = Console.ReadLine();

            Console.Write($"Input hobby: ");
            var hobbyOne = Console.ReadLine();

            Console.Write($"Input another hobby: ");
            var hobbyTwo = Console.ReadLine();

            Console.WriteLine($"Input favorite food: ");
            var favoriteFood = Console.ReadLine();

            Console.WriteLine($"Input an adjective: ");
            var adjective = Console.ReadLine();

            Console.WriteLine($"Input a buff animal: ");
            var buffAnimal = Console.ReadLine();

            Console.WriteLine($"Input a big animal: ");
            var bigAnimal = Console.ReadLine();

            Console.WriteLine($"Input a martial arts style: ");
            var martialArt = Console.ReadLine();


            Console.WriteLine($"There once was a pug named {dogName}. He enjoyed many activities such as {hobbyOne} and {hobbyTwo} while his parents were out of the house." +
            $"{dogName} would splurge on his favorite food, {favoriteFood} also. But there is one interesting fact about this pug." +
            $"{dogName} is one of the best secret agents in the world! His assignment today was to recover the most {adjective} treats in the world." +
            $"There he would fight heavily armed {buffAnimal}. Once he took down all of the security. He made his way to the safe containing the treats." +
            $"As Agent Pug was about to secure the treats, the final boss {bigAnimal} challenged him to a duel. Agent Pug defeated him with his wits and {martialArt}." +
            $"But as he grabbed the treats, the smell of {favoriteFood} woke him up from his nap.");
        }
    }
}
