using AdventOfCode_2022.Day1;
using AdventOfCode_2022.Day2;
using AdventOfCode_2022.Day3;
using System;



namespace AdventOfCode_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('r' - (char)('a' - 1));

            //CalorieCounting day1 = new CalorieCounting(@"inputs\01.txt");

            //day1.part1();
            //day1.part2();



            //RockPaperScissors day2 = new RockPaperScissors(@"inputs\02.txt");

            //day2.part1();
            //day2.part2();



            RucksackReorganization day3 = new RucksackReorganization(@"inputs\03.txt");

            day3.part1();
            day3.part2();

            Console.ReadLine();
        }
    }
}
