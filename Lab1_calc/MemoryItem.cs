using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_calc
{
    internal class MemoryItem
    {
        public double Value
        {
            get;
            private set;
        }

        public MemoryItem(double value)
        {
            Value = value;
        }
        public void Add(double amount)
        {
            Value += amount;
        }

        public void Subtract(double amount)
        {
            Value -= amount;
        }
    }
}
