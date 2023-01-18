using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day2
{
    internal class RockPaperScissors : Puzzle
    {
        public RockPaperScissors(string path) : base(path) { }

        public override void part1()
        {
            string[] moves = new string[2];
            Round round;
            int finalScore = 0;

            foreach (var line in inputs)
            {
                moves = line.Split(' ');
                round = new Round(moves[0], moves[1]);
                finalScore += round.CalculateScore();
            }

            Console.WriteLine($"The final score is: {finalScore}");
        }

        public override void part2()
        {
            Round round;
            int finalScore = 0;

            foreach (var line in inputs)
            {
                round = new Round(line);
                finalScore += round.CalculateScore();
            }

            Console.WriteLine($"The final score is: {finalScore}");
        }
    }
}
