using System;
using System.Collections;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puzzle 1
            String fileName = @"..\..\..\Data.txt";
            //String fileName = @"..\..\..\Test.txt";
            var content = File.ReadAllLines(fileName);
            int x = 0;
            int y = 0;
            for (int i = 0; i < content.Length; i++)
            {
                string[] movement = content[i].Split(' ');
                //Console.WriteLine($"Going to do {movement[0]} in {movement[1]}");
                switch (movement[0].ToLower())
                {
                    case "forward" :
                        x += int.Parse(movement[1]);
                        break;
                    case "down" :
                        y += int.Parse(movement[1]);
                        break;
                    case "up" :
                        y -= int.Parse(movement[1]);
                        break;
                    default :
                        Console.WriteLine($"Unsure what to do with {movement[0]}");
                        break;
                }
            }
            int total = x * y;
            Console.WriteLine($"Submarine is at postion X:{x}, Y:{y} for a combined {total}");

            //Puzzle 2
            x = 0;
            y = 0;
            int aim = 0;
            for (int i = 0; i < content.Length; i++)
            {
                string[] movement = content[i].Split(' ');
                //Console.WriteLine($"Going to do {movement[0]} in {movement[1]}");
                switch (movement[0].ToLower())
                {
                    case "forward":
                        int local_x = int.Parse(movement[1]);
                        x += local_x;
                        if (aim != 0)
                        {
                            y += aim * local_x;
                        }
                        break;
                    case "down":
                        aim += int.Parse(movement[1]);
                        break;
                    case "up":
                        aim -= int.Parse(movement[1]);
                        break;
                    default:
                        Console.WriteLine($"Unsure what to do with {movement[0]}");
                        break;
                }
            }
            total = x * y;
            Console.WriteLine($"Adjusting for Aim submarine is at postion X:{x}, Y:{y} for a combined {total}");

        }
    }
}
