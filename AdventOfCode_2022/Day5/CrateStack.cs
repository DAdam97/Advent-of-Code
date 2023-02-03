using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day5
{
    internal class CrateStack
    {
        public Stack<char> _stack { get; } = new Stack<char>();

        public void LoadCrate(char crate)
        {
            if (crate == 32)
            {
                return;
            }
            _stack.Push(crate);
        }

        public char UnloadCrate()
        {
            return _stack.Pop();
        }

        public char GetTop()
        {
            return _stack.Peek();
        }
    }
}
