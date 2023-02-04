using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day5
{
    internal class SupplyStacks : Puzzle
    {
        public SupplyStacks(string path) : base(path) {  }

        public override void part1()
        {
            (CargoCrane cargoCrane, int cargoHight) = initCargoCrane();

            for (int i = cargoHight - 1; i >= 0; i--)
            {
                cargoCrane.AddCrates(inputLines[i]); 
            }

            int startOfInstructions = cargoHight + 2;

            for (int i = startOfInstructions; i < inputLines.Count; i++)
            {
                cargoCrane.Move(inputLines[i]);
            }

            Console.WriteLine($"{cargoCrane.TopCrates()} crates ends up on the tops of the sracks");
        }

        public override void part2()
        {
            (CargoCrane cargoCrane, int cargoHight) = initCargoCrane();

            for (int i = cargoHight - 1; i >= 0; i--)
            {
                cargoCrane.AddCrates(inputLines[i]);
            }

            int startOfInstructions = cargoHight + 2;

            for (int i = startOfInstructions; i < inputLines.Count; i++)
            {
                cargoCrane.Move(inputLines[i], true);
            }

            Console.WriteLine($"{cargoCrane.TopCrates()} crates ends up on the tops of the sracks");
        }

        private (CargoCrane, int) initCargoCrane()
        {
            int cargoStackSize = 0,
                cargoHight = 0;

            for (int i = 0; i < inputLines.Count - 1; i++)
            {
                if (inputLines[i][1] == '1') 
                {
                    cargoStackSize = getcargoStackSize(inputLines[i]);
                    cargoHight = i;
                    break;
                }
            }

            return (new CargoCrane(cargoStackSize), cargoHight);
        }

        private int getcargoStackSize(string cargoSizeLine)
        {
            int size = 0;

            for (int i = 0; i < cargoSizeLine.Length; i++)
            {
                if (char.IsDigit(cargoSizeLine[i]))
                {
                    size++;
                }
            }

            return size;
        }
    }
}
