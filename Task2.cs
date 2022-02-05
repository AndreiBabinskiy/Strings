using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.IO;


namespace Project1
{
    class Program
    {
        static int m2(out StringBuilder resultString, params StringBuilder[] strings)
        {
            resultString = new StringBuilder();
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length - 1; j = j + 2)
                {
                    var temp = strings[i][j];
                    strings[i][j] = strings[i][j + 1];
                    strings[i][j + 1] = temp;
                }

                resultString.Append(strings[i]);
                if (i != strings.Length - 1) {
                    resultString.Append(";");
                }

            }
            resultString.Capacity = resultString.Length;
            return resultString.Capacity;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1. поменять местами соседние символы");
            StringBuilder[] arrayStrings = new StringBuilder[2]
            {
                new StringBuilder("тикj"),
                new StringBuilder("парe")
                
            };
            foreach (StringBuilder str in arrayStrings)
            {
                Console.WriteLine(str);
            }
            StringBuilder result;
            Console.WriteLine($"Размер буфера: {m2(out result, arrayStrings)}");
            Console.WriteLine("Результирующая строка:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
