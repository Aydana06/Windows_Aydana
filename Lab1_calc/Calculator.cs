using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_calc
{
    internal class Calculator: AbstractClass, Interface1
    {
        public void Add(double value)
        {
            result += value;
        }

        public void Subtract(double value)
        {
            result -= value;
        }

    }
}
