using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day4
{
    internal class IDRange
    {
        public int Start { get; private set; }
        public int End { get; private set; }        

        public IDRange(string range, char delimiter)
        {
            int[] rangeValues = range.Split(delimiter)
                                     .Select(n => int.Parse(n))
                                     .ToArray();

            Start = rangeValues[0];
            End = rangeValues[1];
        }
    }
}
