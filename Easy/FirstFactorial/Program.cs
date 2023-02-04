using System;

namespace FirstFactorial
{
    class Program
    {
        public static int FirstFactorial(int num)
        {
            // code goes here  
            int result = 1;
            for (int i = num; i > 1; i--)
            {
                result *= i;
            }
            return result;

        }

        static void Main()
        {
            Console.WriteLine(FirstFactorial(int.Parse(Console.ReadLine())));
        }
    }
}
