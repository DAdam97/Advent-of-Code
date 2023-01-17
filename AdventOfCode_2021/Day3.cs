using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day3 : Puzzle
    {      
        public override void part1()
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

            Console.WriteLine(gamma * epsilon);
        }

        public override void part2()
        {
            List<string> oxygen = new List<string>(inputs);
            List<string> co2 = new List<string>(inputs);

            int zero = 0;
            int one = 0;
            int oxygenGenRate = 0;
            int co2ScrubRate = 0;


            for (int pos = 0; oxygen.Count > 1; pos++)
            {
                foreach (string bit in oxygen)
                {
                    if (bit[pos] == '0') { zero++; }

                    else { one++; }
                }

                for (int i = oxygen.Count - 1; i >= 0; i--)
                {
                    if (zero > one && oxygen[i][pos] == '1')
                    {
                        oxygen.Remove(oxygen[i]);
                    }
                    else if (zero < one && oxygen[i][pos] == '0')
                    {
                        oxygen.Remove(oxygen[i]);
                    }
                    else if (zero == one && oxygen[i][pos] == '0')
                    {
                        oxygen.Remove(oxygen[i]);
                    }
                }

                one = zero = 0;
            }

            for (int pos = 0; co2.Count > 1; pos++)
            {
                foreach (string bit in co2)
                {
                    if (bit[pos] == '0') { zero++; }

                    else { one++; }
                }

                for (int i = co2.Count - 1; i >= 0; i--)
                {

                    if (zero < one && co2[i][pos] == '1')
                    {
                        co2.Remove(co2[i]);
                    }
                    else if (zero > one && co2[i][pos] == '0')
                    {
                        co2.Remove(co2[i]);
                    }
                    else if (zero == one && co2[i][pos] == '1')
                    {
                        co2.Remove(co2[i]);
                    }

                }

                one = zero = 0;
            }


            oxygenGenRate = Convert.ToInt32(oxygen[0], 2);
            co2ScrubRate = Convert.ToInt32(co2[0], 2);

            Console.WriteLine(oxygenGenRate * co2ScrubRate);
        }


        public Day3(string input) : base(input) { }
    }
}
