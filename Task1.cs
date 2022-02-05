using System;

namespace Laba2_Task2
{
    class Program
    {
        static string str;
        static char chFirst;
        static char chTwo;
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Enter the string ");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Enter the first character ");
            char chFirst = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(" Enter the two character ");
            char chTwo = Convert.ToChar(Console.ReadLine());

            MeetingFrequency(str, chFirst, chTwo);
            Console.Read();
        }
      
        public static void MeetingFrequency(string str, char chFirst, char chTwo)
        {
            int chFirstCount = 0;
            int chTwoCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chFirst)
                {
                    chFirstCount++;
                }
                if (str[i] == chTwo)
                {
                    chTwoCount++;
                }
            }
            if (chFirstCount > chTwoCount)
            {
                Console.WriteLine(" The first character is more common");
            }
            else if (chFirstCount == chTwoCount)
            {
                Console.WriteLine(" Characters are the same ");
            }
            else
            {
                Console.WriteLine(" The second character is more common ");
            }
        }
    }
}
