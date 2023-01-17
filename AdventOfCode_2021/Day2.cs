using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day2 : Puzzle
    {
        public override void part1()
        {
            int depth = 0;
            int horizontal = 0;

            foreach (string instruction in inputs)
            {
                string[] command = instruction.Split(' ');

                switch (command[0])
                {
                    case "forward":
                        horizontal += int.Parse(command[1]);
                        break;

                    case "down":
                        depth += int.Parse(command[1]);
                        break;

                    case "up":
                        depth -= int.Parse(command[1]);
                        break;
                }
            }

            Console.WriteLine(depth * horizontal);
        }

        public override void part2()
        {
            int depth = 0;
            int horizontal = 0;
            int aim = 0;

            foreach (string instruction in inputs)
            {
                string[] command = instruction.Split(' ');

                switch (command[0])
                {
                    case "down":
                        aim += int.Parse(command[1]);
                        break;

                    case "up":
                        aim -= int.Parse(command[1]);
                        break;

                    case "forward":
                        horizontal += int.Parse(command[1]);
                        depth += aim * int.Parse(command[1]);
                        break;
                }
            }

            Console.WriteLine(depth * horizontal);
        }

        public Day2(string input) : base(input) { }
    }
}
