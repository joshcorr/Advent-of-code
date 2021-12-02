using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating...");
            String fileName = @"..\..\..\Data.txt";
            //String fileName = @"..\..\..\Test.txt";
            var lines = File.ReadAllLines(fileName);
            // Puzzle 1
            int lastNumber = 0;
            int currentLine;
            var numberOfIncreases = 0;
            Console.WriteLine($"Total numbers to process {lines.Length}");
            for (var i = 0; i < lines.Length; i++)
            {
                if (i != 0)
                {
                    Int32.TryParse(lines[i], out currentLine);
                    int v = currentLine > lastNumber ? 1: 0;
                    numberOfIncreases = numberOfIncreases + v;
                }
                Int32.TryParse(lines[i], out lastNumber);

            }
            Console.WriteLine($"Sum of number increases {numberOfIncreases}");

            // Puzzle 2
            int lastSet = 0;
            int currentSet = 0;
            var numberOfSetIncreases = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                var max = i + 3;
                if (max <= lines.Length)
                {
                    for (var s = i; s < max; s++)
                    {
                        int x;
                        Int32.TryParse(lines[s], out x);
                        currentSet = currentSet + x;
                    }
                    if (lastSet != 0)
                    {
                        int ls = currentSet > lastSet ? 1 : 0;
                        numberOfSetIncreases = numberOfSetIncreases + ls;
                    }
                    lastSet = currentSet;
                    currentSet = 0;
                }
            }
            Console.WriteLine($"Sum of 'three-measurement sliding window' increases {numberOfSetIncreases}");
        }
    }
}
