using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day4
{
    internal class IDRangePair
    {
        public IDRange A { get; private set; }
        public IDRange B { get; private set; }

        public IDRangePair(string pair, char delimiter)
        {
            string[] rangePairs = pair.Split(delimiter);
            A = new IDRange(rangePairs[0], '-');
            B = new IDRange(rangePairs[1], '-');
        }

        public bool Contains
        {
            get {
                return (A.Start <= B.Start && A.End >= B.End) ||
                       (B.Start <= A.Start && B.End >= A.End);
            }            
        }

        public bool HasOverlap
        {
            get
            {
                return (A.Start <= B.End) && (B.Start <= A.End);
            }
        }
    }
}
