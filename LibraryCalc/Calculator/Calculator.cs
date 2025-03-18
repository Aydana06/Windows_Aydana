using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCalc.Implementation;
using LibraryCalc.Mem;

namespace LibraryCalc.Calculator
{
    public class Calculator : AbstractClass, IInterface
    {
        public Memory memory { get; private set; }
        public Calculator()
        {
            this.memory = new Memory();
        }

        /// <summary>
        /// Тухайн result хувьсагч дээр өгөгдсөн утгыг нэмэх.
        /// </summary>
        /// <param name="value">Нэмэх утга</param>
        public void Add(double value)
        {
            Result += value;
        }
        // Subtract метод нь утга хасах үйлдлийг гүйцэтгэнэ.
        /// <summary>
        /// Тухайн result хувьсагч дээр өгөгдсөн утгыг хасах.
        /// </summary>
        /// <param name="value">Хасах утга</param>
        public void Subtract(double value)
        {
            Result -= value;
        }
        /// <summary>
        /// Тооны машины үр дүнг 0 болгох.
        /// </summary>
        /// 
        public List<MemoryItem> GetMemoryItems()
        {
            return memory.PrintMemoryItems();
        }
        public void Reset()
        {
            Result = 0;
        }

        public void MemorySave()
        {
            memory.Save(Result);
        } 

        public void MemoryAdd(int index, double value)
        {
            var item = memory.GetItem(index);
            if (item != null)
            {
                item.Add(value);
            }
        }

        public void MemorySubtract(int index, double value)
        {
            var item = memory.GetItem(index);
            if (item != null)
            {
                item.Subtract(value);
            }
        }
        public void MemoryRemove(int index)
        {
            if (index >= 0 && index < memory.memoryItems.Count)
            {
                memory.memoryItems.RemoveAt(index);
            }
        }

        public void RemoveMemoryItem(MemoryItem item)
        {
            memory.memoryItems.Remove(item);
        }
    }
}
