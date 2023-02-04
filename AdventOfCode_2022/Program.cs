using AdventOfCode_2022.Day1;
using AdventOfCode_2022.Day2;
using AdventOfCode_2022.Day3;
using AdventOfCode_2022.Day4;
using AdventOfCode_2022.Day5;
using AdventOfCode_2022.Day6;
using System;

namespace AdventOfCode_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalorieCounting day1 = new CalorieCounting(@"inputs\01.txt");

            //day1.part1();
            //day1.part2();



            //RockPaperScissors day2 = new RockPaperScissors(@"inputs\02.txt");

            //day2.part1();
            //day2.part2();



            //RucksackReorganization day3 = new RucksackReorganization(@"inputs\03.txt");

            //day3.part1();
            //day3.part2();



            //CampCleanup day4 = new CampCleanup(@"inputs\04.txt");

            //day4.part1();
            //day4.part2();



            //SupplyStacks day5 = new SupplyStacks(@"inputs\05.txt");

            //day5.part1();
            //day5.part2();



            TuningTrouble day6 = new TuningTrouble(@"inputs\06.txt");

            day6.part1();
            day6.part2();

            Console.ReadLine();
        }
    }
}
