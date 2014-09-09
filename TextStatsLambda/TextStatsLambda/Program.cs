using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStatsLambda("The beautiful people.");
            Console.ReadKey();
        }
        static void TextStatsLambda(string input)
        {
            //finding the characters by input.Length
            Console.WriteLine("There are : " + input.Length + " characters.");
            //finding the words by splitting the input by spaces, then to a list, then counting it
            Console.WriteLine("There are : " + input.Split(' ').ToList().Count() + " words.");
            //finding the vowels by setting the input to lowercase, counting every time x = a vowel
            Console.WriteLine("There are : " + input.ToLower().Count(x => "aeiou".Contains(x)) + " vowels.");
            //same for consonants
            Console.WriteLine("There are : " + input.ToLower().Count(x => "bcdfghjklmnpqrstvwxyz".Contains(x)) + " consonants.");
            //just putting a !not modifier to do the oposite of finding the vowels / consonants
            Console.WriteLine("There are : " + input.ToLower().Count(x => !"abcdefghijklmnopqrstuvwxyz".Contains(x)) + " special characters.");
            //ordering them by length then printing the last
            Console.WriteLine("The longest word is : " + input.ToLower().Split(' ').ToList().OrderBy(x => x.Length).Last());
            //same for the first
            Console.WriteLine("The shortest word is : " + input.ToLower().Split(' ').ToList().OrderBy(x => x.Length).First());
        }
    }
}
