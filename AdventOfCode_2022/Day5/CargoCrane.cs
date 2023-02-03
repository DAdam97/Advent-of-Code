using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day5
{
    internal class CargoCrane
    {
        private List<CrateStack> _cargos = new List<CrateStack>();

        public CargoCrane(int numberOfStacks)
        {
            for (int i = 0; i < numberOfStacks; i++)
            {
                _cargos.Add(new CrateStack());
            }
        }

        public void Move(string instruction, bool multiple = false)
        {
            string[] parts = instruction.Split(' ');

            int quantity = int.Parse(parts[1]),
                from = int.Parse(parts[3]) - 1,
                to = int.Parse(parts[5]) - 1;

            if (multiple)
            {
                MoveMultiple(quantity, from, to);
            }
            else
            {
                MoveOne(quantity, from, to);
            }
        }
        private void MoveMultiple(int quantity, int from, int to)
        {
            List<char> list = new List<char>(quantity);

            for (int i = 0; i < quantity; i++)
            {
                list.Add(_cargos[from].UnloadCrate());
            }

            for (int i = quantity - 1; i >= 0; i--)
            {
                _cargos[to].LoadCrate(list[i]);
            }
        }

        private void MoveOne(int quantity, int from, int to)
        {
            for (int i = 0; i < quantity; i++)
            {
                _cargos[to].LoadCrate(_cargos[from].UnloadCrate());
            }
        }


        private void print()
        {
            for (int i = 0; i < _cargos.Count; i++)
            {
                
            }
        }

        public void AddCrates(string crates)
        {
            int crateIndex = 0;

            for (int i = 1; i < crates.Length; i += 4)
            {
                _cargos[crateIndex].LoadCrate(crates[i]);
                crateIndex++;
            }           
        }

        public string TopCrates()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _cargos.Count; i++)
            {
                sb.Append(_cargos[i].GetTop());
            }

            return sb.ToString();
        }
    }
}
