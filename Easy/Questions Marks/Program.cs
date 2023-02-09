using System;

namespace Questions_Marks
{
    class Program
    {
        public static string QuestionsMarks(string str)
        {
            // code goes here  
            string result = string.Empty;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if (int.TryParse(letter.ToString(), out int num))
                {
                    for (int j = i; j < str.Length; j++)
                    {
                        char secondNum = str[j];
                        if (secondNum == 63)
                        {
                            count++;
                        }

                        if (int.TryParse(secondNum.ToString(), out int digit) && count != 0 && count % 3 == 0)
                        {
                            count = 0;
                            result = "true";
                            break;
                        }
                        else if (int.TryParse(secondNum.ToString(), out int number) && count % 3 != 0)
                        {
                            count = 0;
                            result = "false";
                            break;
                        }

                        i = j;
                    }
                    
                }

                if (result == "false")
                {
                    break;
                }

            }

            return result;
        }
        static void Main()
        {
            // keep this function call here
            Console.WriteLine(QuestionsMarks(Console.ReadLine()));
        }
    }
}
