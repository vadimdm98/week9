using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[]
{
  "red",
  "blue",
  "green"
};

            Console.Write("Hi, enter your favorite color: ");

            string userColor = Console.ReadLine().ToLower();

            if (Array.Exists(colors, color => color.Equals(userColor)))
            {
                Console.WriteLine("We are perfect together.");
            }
            else
            {
                Console.WriteLine("Every man to his taste.");
            }
        }
    }
}
