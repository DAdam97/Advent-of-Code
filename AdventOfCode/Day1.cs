﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day1 : Puzzle
    {
        public override int part1()
        {
            int depthsInc = 0;

            for (int i = 0; i < inputs.Count - 1; i++)
            {
                if (int.Parse(inputs[i]) < int.Parse(inputs[i + 1]))
                {
                    depthsInc++;
                }
            }

            return depthsInc;
        }

        public override int part2()
        {
            int depthsInc = 0;

            for (int i = 0; i < inputs.Count - 3; i++)
            {
                int a = int.Parse(inputs[i]) + int.Parse(inputs[i + 1]) + int.Parse(inputs[i + 2]);
                int b = int.Parse(inputs[i + 1]) + int.Parse(inputs[i + 2]) + int.Parse(inputs[i + 3]);

                if (a < b)
                {
                    depthsInc++;
                }
            }

            return depthsInc;
        }

        public Day1(string inputFile) : base(inputFile) { }
    }
}