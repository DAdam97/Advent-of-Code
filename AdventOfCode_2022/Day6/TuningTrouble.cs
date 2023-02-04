using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day6
{
    internal class TuningTrouble : Puzzle
    {
        public TuningTrouble(string path) : base(path) { }

        public override void part1()
        {
            int signalLength = 4;
            List<SignalData> marker = new List<SignalData>(signalLength);

            for (int i = 0; i < FullInput.Length; i++)
            {
                for (int j = 0; j < signalLength; j++)
                {
                    marker.Add(new SignalData(FullInput[i + j], i + j));
                }

                if (!SignalData.IsStartMarker(marker, signalLength))
                {
                    i = SignalData.GetFirstRepeatedValueIndex(marker);
                    marker.Clear();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{marker[signalLength - 1].Index + 1} characters needed to be processed for the start-of-packet marker.");
        }

        public override void part2()
        {
            int signalLength = 14;
            List<SignalData> marker = new List<SignalData>(signalLength);

            for (int i = 0; i < FullInput.Length; i++)
            {
                for (int j = 0; j < signalLength; j++)
                {
                    marker.Add(new SignalData(FullInput[i + j], i + j));
                }

                if (!SignalData.IsStartMarker(marker, signalLength))
                {
                    i = SignalData.GetFirstRepeatedValueIndex(marker);
                    marker.Clear();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{marker[signalLength - 1].Index + 1} characters needed to be processed for the start-of-message marker.");
        }
    }
}
