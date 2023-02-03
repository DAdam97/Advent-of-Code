using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode
{
    public abstract class Puzzle
    {
        public List<string> inputLines;
        public string FullInput { get; private set; }

        public abstract void part1();

        public abstract void part2();

        public Puzzle(string path)
        {
            inputLines = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();

            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string temp;
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();
                    inputLines.Add(temp);
                    stringBuilder.Append(temp);
                }
                FullInput = stringBuilder.ToString();
            }
        }
    }
}
