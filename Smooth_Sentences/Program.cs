using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smooth_Sentences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a sentence:");
                string input = Console.ReadLine();

                string[] words = input.Split(new char[] { ' ', ',', '.', ':', ';', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);

                bool isChain = true;
                for (int i = 0; i < words.Length - 1; i++)
                {
                    char lastLetter = words[i][words[i].Length - 1];
                    char firstLetter = words[i + 1][0];
                    if (char.ToLower(lastLetter) != char.ToLower(firstLetter))
                    {
                        isChain = false;
                        break;
                    }
                }

                if (isChain)
                {
                    Console.WriteLine("The Sentence is Smooth!");
                }
                else
                {
                    Console.WriteLine("The sentence is NOT Smooth!");
                }

                Console.ReadLine();
            }
        }
    }
}
