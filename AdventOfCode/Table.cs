using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{

    public class Table
    {
        public Number[,] Numbers;


        public void Mark(int num)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Numbers[i, j].Value == num)
                    {
                        Numbers[i, j].Marked = true;
                        return;
                    }
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(this.Numbers[i, j].Value + " ");
                }
                Console.WriteLine();
            }
        }

        public int GetUnmarkedSum()
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!Numbers[i, j].Marked)
                    {
                        sum += Numbers[i, j].Value;
                    }
                }
            }

            return sum;
        }

        public bool IsWiningTable()
        {
            int points = 0;

            // check rows
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Numbers[i,j].Marked)
                    {
                        points++;
                    }
                }

                if (points == 5)
                {
                    return true;
                }

                points = 0;
            }

            // check columns
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Numbers[j, i].Marked)
                    {
                        points++;
                    }
                }

                if (points == 5)
                {
                    return true;
                }

                points = 0;
            }

            return false;
        }


        public Table(List<int> tableNums)
        {
            Numbers = new Number[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Numbers[i, j] = new Number(tableNums[i * 5 + j]);
                }
            }
        }
    }
}
