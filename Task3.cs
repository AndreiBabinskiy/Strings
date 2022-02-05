using System;
using System.Text.RegularExpressions;

namespace Laba2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Convert.ToString(Console.ReadLine());
            solutionTask(str);
        }

        public static void solutionTask(string str) {
            Regex reg = new Regex(@"(\w*)");
            
            string[] words = reg.Split(str);
            Console.WriteLine("Enter n letters:");
            int n = int.Parse(Console.ReadLine());

            foreach (string word in words)
            {
                if (word.Length > n)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }

    }
}
