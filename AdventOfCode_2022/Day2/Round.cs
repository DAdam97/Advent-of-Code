using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day2
{
    [DebuggerDisplay("{Opponent} vs {Player}")]
    internal class Round
    {
        public MoveType Opponent { get; set; }
        public MoveType Player { get; set; }

        public Round(string opponent, string player)
        {
            this.Opponent = DecryptMove(opponent);
            this.Player = DecryptMove(player);
        }

        public Round(string move)
        {
            string[] moves = move.Split(' ');
            this.Opponent = DecryptMove(moves[0]);
            this.Player = SelectStrategy(moves[1]);
        }

        public int CalculateScore()
        {
            int score = 0;

            if (Opponent == Player)
            {
                score += 3;
            }
            else if (Player == MoveType.Rock && Opponent == MoveType.Scissoers ||
                     Player == MoveType.Paper && Opponent == MoveType.Rock ||
                     Player == MoveType.Scissoers && Opponent == MoveType.Paper)
            {
                score += 6;
            }

            switch (Player)
            {
                case MoveType.Rock:
                    score += 1;
                    break;

                case MoveType.Paper:
                    score += 2;
                    break;

                case MoveType.Scissoers:
                    score += 3;
                    break;

                case MoveType.None:
                default:
                    break;
            }

            return score;
        }

        private MoveType DecryptMove(string move)
        {
            switch (move)
            {
                case "A":
                case "X":
                    return MoveType.Rock;

                case "B":
                case "Y":
                    return MoveType.Paper;

                case "C":
                case "Z":
                    return MoveType.Scissoers;

                default:
                    return MoveType.None;
            }
        }

        private MoveType SelectStrategy(string strategy)
        {
            switch (strategy)
            {
                case "X":
                    return SelectLosingMove(Opponent);

                case "Y":
                    return Opponent;

                case "Z":
                    return SelectWinningMove(Opponent);

                default:
                    return MoveType.None;
            }
        }
        private MoveType SelectLosingMove(MoveType opponent)
        {
            switch (opponent)
            {
                case MoveType.Rock:
                    return MoveType.Scissoers;

                case MoveType.Paper:
                    return MoveType.Rock;

                case MoveType.Scissoers:
                    return MoveType.Paper;

                case MoveType.None:
                default:
                    return MoveType.None;
            }
        }
        private MoveType SelectWinningMove(MoveType opponent)
        {
            switch (opponent)
            {
                case MoveType.Rock:
                    return MoveType.Paper;

                case MoveType.Paper:
                    return MoveType.Scissoers;

                case MoveType.Scissoers:
                    return MoveType.Rock;

                case MoveType.None:
                default:
                    return MoveType.None;
            }
        }
    }
}
