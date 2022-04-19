using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    class Day7 : Puzzle
    {
        List<int> positions = new List<int>();
        Dictionary<int, int> positionStat = new Dictionary<int, int>();
        List<KeyValuePair<int, int>> orderedPositions = new List<KeyValuePair<int, int>>();


        public override void part1()
        {
            int totalFuel = 0;
            int minFuel = int.MaxValue;
            int bestPosition = 0;

            int middlePosition = orderedPositions.Count / 2;
            int offset = 0;

            int positionToAlign = 0;
            int positionsToCheck = orderedPositions.Count / 2;

            for (int i = 0; i < positionsToCheck; i++)
            {
                positionToAlign = orderedPositions[middlePosition + offset].Key;

                for (int j = 0; j < orderedPositions.Count; j++)
                {
                    int fuel = Math.Abs(orderedPositions[j].Key - positionToAlign);
                    int amont = orderedPositions[j].Value;

                    totalFuel += fuel * amont;
                }

                if (totalFuel < minFuel)
                {
                    minFuel = totalFuel;
                    bestPosition = positionToAlign;
                }

                totalFuel = 0;

                if (i % 2 == 0)
                {
                    offset *= -1;
                    offset++;
                }
                else
                {
                    offset *= -1;
                }
            }

            Console.WriteLine($"The crabs need to spend {minFuel} fuel to align {bestPosition}");
        }

        public override void part2()
        {
            int totalFuel = 0;
            int minFuel = int.MaxValue;
            int bestPosition = 0;

            int offset = orderedPositions.Count / 10;
            int middle = orderedPositions.Count / 2;

            int from = orderedPositions[middle - offset].Key;
            int to = orderedPositions[middle + offset].Key;


            for (int positionToAlign = from; positionToAlign < to; positionToAlign++)
            {
                for (int j = 0; j < orderedPositions.Count; j++)
                {
                    int distance = Math.Abs(orderedPositions[j].Key - positionToAlign);
                    int fuel = ((distance + 1) * distance) / 2;

                    int amont = orderedPositions[j].Value;

                    totalFuel += fuel * amont;
                }

                if (totalFuel < minFuel)
                {
                    minFuel = totalFuel;
                    bestPosition = positionToAlign;
                }

                totalFuel = 0;
            }

            Console.WriteLine($"The crabs need to spend {minFuel} fuel to align {bestPosition}");
        }

        public Day7(string input) : base(input)
        {
            foreach (string position in inputs[0].Split(','))
            {
                positions.Add(int.Parse(position));
            }

            foreach (int pos in positions)
            {
                if (!positionStat.ContainsKey(pos))
                {
                    positionStat.Add(pos, 1);
                }
                else
                {
                    positionStat[pos]++;
                }
            }

            positionStat = positionStat.OrderBy(key => key.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in positionStat)
            {
                orderedPositions.Add(kvp);
            }
        }
    }
}
