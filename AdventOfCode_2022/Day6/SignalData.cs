using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day6
{
    [DebuggerDisplay("{Value} - {Index}")]
    internal struct SignalData
    {
        public char Value { get; }
        public int Index { get; }

        public SignalData(char value, int index)
        {
            Value = value;
            Index = index;
        }

        public static bool IsStartMarker(List<SignalData> signalValues, int markerLength)
        {
            Dictionary<char, int> signalFrequency = new Dictionary<char, int>();

            for (int i = 0; i < signalValues.Count; i++)
            {
                if (!signalFrequency.ContainsKey(signalValues[i].Value))
                {
                    signalFrequency.Add(signalValues[i].Value, 1);
                }
                else
                {
                    signalFrequency[signalValues[i].Value]++;
                }
            }

            return signalFrequency.Count == markerLength;
        }

        public static int GetFirstRepeatedValueIndex(List<SignalData> signalValues)
        {
            int index = -1;

            for (int i = 0; i < signalValues.Count; i++)
            {
                for (int j = signalValues.Count - 1; j >= 0; j--)
                {
                    if (i != j && signalValues[i].Value == signalValues[j].Value)
                    {
                        return signalValues[i].Index;
                    } 
                }                
            }

            return index;
        }
    }
}
