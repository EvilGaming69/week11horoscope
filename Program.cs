using System;
using System.IO;

namespace colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a color: (red,blue,green,yellow");
            string color = Console.ReadLine();
            Console.WriteLine(GetHoroScope(color));
        }
        public static string[] Getpersonality()
        {
            string filePath = @"C:\Users\opilane\samples\personality.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            Console.WriteLine(dataFromFile.Length);

            return dataFromFile;

        }
        public static string GetHoroScope(string userInput)
        {
            string[] horoscope = ReadHoroScope();
            string todayHoroscope = "";

            foreach (string elements in horoscope)
            {
                if (elements.Contains(userInput))
                {
                    todayHoroscope = elements;
                }

            }

            return todayHoroscope;
        }

    }
}
//ja ne zakon4il