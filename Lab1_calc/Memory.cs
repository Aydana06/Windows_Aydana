using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_calc
{
    internal class Memory
    {
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        public void Save(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        public List<MemoryItem> GetAll()
        {
            return memoryItems;
        }

        public double Recall()
        {
            return memoryItems.Count > 0 ? memoryItems[^1].Value : 0;
        }

        public void Clear()
        {
            memoryItems.Clear();
        }

        public MemoryItem? GetItem(int index)
        {
            if (index >= 0 && index < memoryItems.Count)
                return memoryItems[index];
            else
                return null;
        }
    }
}
