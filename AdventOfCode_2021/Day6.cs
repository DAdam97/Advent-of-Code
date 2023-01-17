using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day6 : Puzzle
    {
        public override void part1()
        {
            int population = 0;

            List<int> lanternfishes = new List<int>();
            const int newFish = 8;
            const int resetFish = 6;

            const int daysToSimulate = 80;

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

            Console.WriteLine(population);
        }


        public override void part2()
        {
            long population = 0;
            const int daysToSimulate = 256;
            const int lifeCycle = 9;

            long[] lanternfishes = new long[lifeCycle];
            string[] initialState = inputs[0].Split(',');

            for (int i = 0; i < initialState.Length; i++)
            {
                long leftToReproduce = long.Parse(initialState[i]);
                lanternfishes[leftToReproduce]++;
            }

            for (int day = 0; day < daysToSimulate; day++)
            {
                for (int i = 0; i < lifeCycle - 1; i++)
                {
                    long tempFish = lanternfishes[i];
                    lanternfishes[i] = lanternfishes[i + 1];
                    lanternfishes[i + 1] = tempFish;
                }

                lanternfishes[6] += lanternfishes[8];
            }

            for (int i = 0; i < lifeCycle; i++)
            {
                population += lanternfishes[i];
            }

            Console.WriteLine(population);
        }
        

        public Day6(string input) : base(input) { }
    }
}
