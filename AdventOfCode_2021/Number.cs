using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Number
    {
        public int Value { get; set; }
        public bool Marked { get; set; }

        public Number(int value)
        {
            this.Value = value;
            this.Marked = false;
        }
    }
}
