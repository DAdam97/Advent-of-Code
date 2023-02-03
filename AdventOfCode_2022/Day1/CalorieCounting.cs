using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day1
{
    internal class CalorieCounting : Puzzle
    {
        
        List<Elf> elves = new List<Elf>();

        public CalorieCounting(string path) : base(path) { }

        public override void part1()
        {
            Elf elf = new Elf();

            foreach (string line in inputLines)
            {
                if (line == "")
                {
                    elves.Add(elf);
                    elf = new Elf();
                }
                else
                {
                    elf.AddMeal(int.Parse(line));
                }
            }
            elves.Add(elf);

            int max = 0;
            int index = 0;

            for (int i = 0; i < elves.Count; i++)
            {
                if (elves[i].MaxCalories >= max)
                {
                    max = elves[i].MaxCalories;
                    index = i;
                }
            }

            Console.WriteLine($"the {index+1}. elf is carrying the most Calories: {max}");
        }

        public override void part2()
        {
            elves = elves.OrderByDescending(elf => elf.MaxCalories).ToList();

            Console.WriteLine($"the top 3 elves is carrying {elves[0].MaxCalories + elves[1].MaxCalories + elves[2].MaxCalories} Calories");
        }
    }
}
