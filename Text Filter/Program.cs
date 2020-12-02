using System;

namespace textfilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWorlds = Console.ReadLine().Split(' ');
            string text = Console.ReadLine();
            foreach (var banWord in banWorlds)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, "***");
                }
            }
            Console.WriteLine(text);
        }
    }
}
