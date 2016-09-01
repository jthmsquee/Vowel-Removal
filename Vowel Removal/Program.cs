using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Removal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word.");

            try
            {
                string wordEntered = Console.ReadLine();
                int Vowels = 0;
                StringBuilder notAVowel = new StringBuilder();

                for (int i = 0; i < wordEntered.Length; i++)
                {
                    string c = wordEntered[i].ToString();
                    if ("aeiouAEIOU".Contains(c))
                    {
                        Vowels++;
                    }
                    if ("aeiouAEIOU".Contains(c) != true)
                    {
                        notAVowel.Append(c);
                    }
                }
                Console.WriteLine(notAVowel);
                Console.WriteLine(Vowels);
            }
            catch(Exception idk)
            {
                Console.WriteLine(idk.Message);
            }
            Console.ReadLine();
        }
    }
}
