using System;
using System.Linq;
using System.Timers;
using System.Threading;

namespace HobbyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HobbyGenerator();
            }
        }
        public static void HobbyGenerator()
        {
            Console.WriteLine("Who would like a new hobby?");
            string yourName = Console.ReadLine();
            string[] hobbies = new string[5] { "Reading", "League", "Drawing", "Coding", "Nothing" };
            Random rnd = new Random();
            int num = rnd.Next(0, hobbies.Length);
            Console.WriteLine(yourName + " has a hobby of " + hobbies[num]);
        }
    }
}