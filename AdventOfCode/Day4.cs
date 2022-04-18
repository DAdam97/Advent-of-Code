using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day4 : Puzzle
    {
        string[] randomNums;

        List<int> tableNums = new List<int>();
        List<Table> tables = new List<Table>();

        int lastNumber = 0;
        Table winningTable = null;
        bool winningTableFound = false;
        int unmarkedNumbersSum = 0;


        public override void part1()
        {
            for (int i = 0; i < randomNums.Length; i++)
            {
                for (int j = 0; j < tables.Count; j++)
                {
                    lastNumber = int.Parse(randomNums[i]);

                    tables[j].Mark(lastNumber);

                    if (tables[j].IsWiningTable())
                    {
                        winningTableFound = true;
                        winningTable = tables[j];
                        break;
                    }
                }

                if (winningTableFound) break;
            }

            unmarkedNumbersSum = winningTable.GetUnmarkedSum();

            Console.WriteLine(unmarkedNumbersSum * lastNumber);
        }


        public override void part2()
        {
            List<Table> wonBoards = new List<Table>();

            winningTableFound = false;
            foreach (Table table in tables)
            {
                table.ResetMarks();
            }


            for (int i = 0; i < randomNums.Length; i++)
            {
                for (int j = 0; j < tables.Count; j++)
                {
                    lastNumber = int.Parse(randomNums[i]);

                    tables[j].Mark(lastNumber);

                    if (tables[j].IsWiningTable() && !wonBoards.Contains(tables[j]))
                    {
                        wonBoards.Add(tables[j]);
                    }

                    if (wonBoards.Count == tables.Count)
                    {
                        winningTableFound = true;
                        winningTable = tables[j];
                        break;
                    }
                }

                if (winningTableFound) break;

            }

            unmarkedNumbersSum = winningTable.GetUnmarkedSum();

            Console.WriteLine(unmarkedNumbersSum * lastNumber);
        }


        public Day4(string input) : base(input)
        {
            randomNums = inputs[0].Split(',');

            for (int i = 2; i < inputs.Count; i++)
            {
                string[] nums = inputs[i].Replace("  ", " ").Trim().Split(' ');

                for (int j = 0; j < nums.Length && nums.Length > 1; j++)
                {
                    tableNums.Add(int.Parse(nums[j]));
                }

                if (inputs[i] == "")
                {
                    tables.Add(new Table(tableNums));
                    tableNums.Clear();
                }
            }
        }
    }
}
