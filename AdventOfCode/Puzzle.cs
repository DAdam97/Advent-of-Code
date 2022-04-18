using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    abstract class Puzzle
    {
       public List<string> inputs;


        public abstract void part1();

        public abstract void part2();


        public Puzzle(string input)
        {
            inputs = new List<string>();

            using (StreamReader sr = new StreamReader(input, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    inputs.Add(sr.ReadLine());
                }
            }
        }
    }
}
