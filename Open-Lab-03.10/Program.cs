using System;

namespace Open_Lab_03._10
{
    class Program
    {
        public static int GetNumberOfCharsInString(char letter, string str)
        {
            int i = 0;
            char[] word = str.ToCharArray();
            foreach (var a in word)
            {
                if (a == letter)
                {
                    i++;
                }
            }
            return i;
        }
        static void Main(string[] args)
        {
            char a = Convert.ToChar(Console.ReadLine());
            string b = Console.ReadLine();
            Console.WriteLine(GetNumberOfCharsInString(a, b));

        }
    }
}
