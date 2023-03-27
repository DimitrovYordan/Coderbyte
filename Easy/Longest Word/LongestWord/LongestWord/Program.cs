using System;

namespace LongestWord
{
    class Program
    {
        public static string LongestWord(string sen)
        {
            string[] current = sen.Split(" ");
            string result = string.Empty;

            for (int i = 0; i < current.Length; i++)
            {
                if (i >= result.Length)
                {
                    result = current[i];
                }
            }

            // code goes here  
            return result;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }
    }
}