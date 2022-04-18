using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day6 : Puzzle
    {
        public override int part1()
        {
            List<int> lanternfishes = new List<int>();
            int population = 0;

            const int daysToSimulate = 80;
            const int newFish = 8;
            const int resetFish = 6;

            foreach (string fish in inputs[0].Split(','))
            {
                lanternfishes.Add(int.Parse(fish));
            }

            for (int day = 0; day < daysToSimulate; day++)
            {
                for (int i = lanternfishes.Count - 1; i >= 0; i--)
                {
                    lanternfishes[i]--;

                    if (lanternfishes[i] == -1)
                    {
                        lanternfishes.Add(newFish);
                        lanternfishes[i] = resetFish;
                    }
                }
            }

            population = lanternfishes.Count;

            return population;
        }

        public override int part2()
        {
            throw new NotImplementedException();
        }

        public Day6(string input) : base(input) { }
    }
}
