using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] furtunes = new string[]
{
  "win a Jackpot",
  "fall in love",
  "get a love letter",
  "miss the bus",
  "see a unicorn un the street"
};

            Console.WriteLine("Your cookie is: {0}", furtunes.GetValue(new Random().Next(furtunes.Length)));
        }
    }
}
