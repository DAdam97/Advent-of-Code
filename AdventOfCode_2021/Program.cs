using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Puzzle day1 = new Day1(@"inputs\01.txt");

            day1.part1();
            day1.part2();



            Puzzle day2 = new Day2(@"inputs\02.txt");

            day2.part1();
            day2.part2();



            Puzzle day3 = new Day3(@"inputs\03.txt");

            day3.part1();
            day3.part2();



            Puzzle day4 = new Day4(@"inputs\04.txt");

            day4.part1();
            day4.part2();



            Puzzle day5 = new Day5(@"inputs\05.txt");

            day5.part1();
            day5.part2();



            Puzzle day6 = new Day6(@"inputs\06.txt");

            day6.part1();
            day6.part2();
            


            Puzzle day7 = new Day7(@"inputs\07.txt");

            day7.part1();
            day7.part2();

            


            Console.ReadLine();
        }
    }
}
