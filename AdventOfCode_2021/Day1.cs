using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day1 : Puzzle
    {
        public override void part1()
        {
            int depthsInc = 0;

            for (int i = 0; i < inputLines.Count - 1; i++)
            {
                if (int.Parse(inputLines[i]) < int.Parse(inputLines[i + 1]))
                {
                    depthsInc++;
                }
            }

            Console.WriteLine(depthsInc);
        }

        public override void part2()
        {
            int depthsInc = 0;

            for (int i = 0; i < inputLines.Count - 3; i++)
            {
                int a = int.Parse(inputLines[i]) + int.Parse(inputLines[i + 1]) + int.Parse(inputLines[i + 2]);
                int b = int.Parse(inputLines[i + 1]) + int.Parse(inputLines[i + 2]) + int.Parse(inputLines[i + 3]);

                if (a < b)
                {
                    depthsInc++;
                }
            }

            Console.WriteLine(depthsInc);
        }

        public Day1(string inputFile) : base(inputFile) { }
    }
}
