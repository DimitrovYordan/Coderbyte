using System;

namespace FirstReverse
{
    class MainClass
    {

        public static string FirstReverse(string str)
        {
            //char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);

            string reversedWords = String.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedWords += str[i];
            }

            return reversedWords;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }

    }
}
