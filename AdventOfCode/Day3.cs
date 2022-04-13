using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day3 : Puzzle
    {      
        public override int part1()
        {
            int[] gammaRate = new int[inputs[0].Length];
            int[] epsilonRate = new int[inputs[0].Length];

            string strGamma = "";
            string strEpsilon = "";

            int gamma = 0;
            int epsilon = 0;

            foreach (string binaryNum in inputs)
            {
                for (int bit = 0; bit < binaryNum.Length; bit++)
                {
                    if (binaryNum[bit] == '1')
                    {
                        gammaRate[bit]++;
                    }
                    else
                    {
                        epsilonRate[bit]++;
                    }
                }
            }


            for (int i = 0; i < gammaRate.Length; i++)
            {
                if (gammaRate[i] > epsilonRate[i])
                {
                    strGamma += '1';
                    strEpsilon += '0';
                }
                else
                {
                    strEpsilon += '1';
                    strGamma += '0';
                }
            }

            gamma = Convert.ToInt32(strGamma, 2);
            epsilon = Convert.ToInt32(strEpsilon, 2);

            return gamma * epsilon;
        }

        public override int part2()
        {




            return -1;
        }


        public Day3(string input) : base(input) { }
    }
}
