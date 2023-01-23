using AdventOfCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day4
{
    internal class CampCleanup : Puzzle
    {
        public CampCleanup(string path) : base(path) { }

        public override void part1()
        {
            int ContainsCount = 0;

            foreach (var line in inputs)
            {
                IDRangePair pair = new IDRangePair(line, ',');

                if (pair.Contains)
                {
                    ContainsCount++;
                }                
            }

            Console.WriteLine($"{ContainsCount} assignment pairs contains eachother.");
        }       

        public override void part2()
        {
            int OverlapCount = 0;

            foreach (var line in inputs)
            {
                IDRangePair pair = new IDRangePair(line, ',');

                if (pair.HasOverlap)
                {
                    OverlapCount++;
                }
            }

            Console.WriteLine($"{OverlapCount} assignment pairs overlap eachother.");
        }       
    }
}
