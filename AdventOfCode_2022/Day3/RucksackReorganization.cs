using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day3
{
    internal class RucksackReorganization : Puzzle
    {
        public RucksackReorganization(string path) : base(path) { }

        public override void part1()
        {
            Rucksack rucksack;
            int sumOfPriorities = 0;

            foreach (var items in inputLines)
            {
                rucksack = new Rucksack(items);
                char common = rucksack.GetCommonItemInside();
                sumOfPriorities += rucksack.GetItemPriority(common);
            }

            Console.WriteLine($"the sum of the priorities is {sumOfPriorities}");
        }

        public override void part2()
        {
            Rucksack rucksack1;
            Rucksack rucksack2;
            Rucksack rucksack3;

            int sumOfPriorities = 0;
            int i;

            for (i = 0; i < inputLines.Count; i += 3)
            {
                rucksack1 = new Rucksack(inputLines[i]);
                rucksack2 = new Rucksack(inputLines[i + 1]);
                rucksack3 = new Rucksack(inputLines[i + 2]);

                char common = rucksack1.GetCommonItemOf3Rucksacks(rucksack2, rucksack3);
                sumOfPriorities += rucksack1.GetItemPriority(common);
            }

            Console.WriteLine($"the sum of the priorities is {sumOfPriorities} of the three group");
        }
    }
}
