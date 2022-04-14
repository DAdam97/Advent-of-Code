using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day4 : Puzzle
    {
        public override int part1()
        {
            string[] randomNums = inputs[0].Split(',');

            List<Table> tables = new List<Table>();


            List<int> tableNums = new List<int>();

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


            int lastNumber = 0;
            Table winningTable = null;
            bool winningTableFound = false;
           
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

            int unmarkedNumbersSum = winningTable.GetUnmarkedSum();

            return unmarkedNumbersSum * lastNumber;
        }

        public override int part2()
        {
            throw new NotImplementedException();
        }


        public Day4(string input) : base(input)
        {

        }
    }
}
