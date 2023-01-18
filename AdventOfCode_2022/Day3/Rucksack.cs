using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day3
{
    internal class Rucksack
    {
        public string FirstCompartment { get; }
        public string SecondCompartment { get; }
        public string Items { get; }


        public Rucksack(string items)
        {
            FirstCompartment = items.Substring(0, items.Length / 2);
            SecondCompartment = items.Substring(items.Length / 2);
            Items = FirstCompartment + SecondCompartment;
        }

        public char GetCommonItemInside()
        {
            foreach (var item in FirstCompartment)
            {
                if (SecondCompartment.Contains(item))
                {
                    return item;
                }
            }

            return ' ';
        }

        public char GetCommonItemOf3Rucksacks(Rucksack two, Rucksack three)
        {  
            return Items.Intersect(two.Items).Intersect(three.Items).First();
        }

        public int GetItemPriority(char item)
        {
            int priority;

            if (char.IsLower(item))
            {
                priority = item - (char)('a' - 1);
            }
            else
            {
                priority = item - (char)('A' - 1) + 26;
            }

            return priority;
        }
    }
}
