using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022.Day1
{
    [DebuggerDisplay("{MaxCalories}")]
    class Elf
    {
        List<int> Meals;
        int max = 0;

        public int MaxCalories
        {
            get
            {
                return max;
            }
        }

        public Elf()
        {
            Meals = new List<int>();
        }

        public void AddMeal(int meal)
        {
            Meals.Add(meal);
            max += meal;
        }
    }
}
