using AdventOfCode_2022.Day1;
using AdventOfCode_2022.Day2;
using System;



namespace AdventOfCode_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalorieCounting day1 = new CalorieCounting(@"inputs\01.txt");

            day1.part1();
            day1.part2();



            RockPaperScissors day2 = new RockPaperScissors(@"inputs\02.txt");

            day2.part1();
            day2.part2();


            Console.ReadLine();
        }
    }
}
