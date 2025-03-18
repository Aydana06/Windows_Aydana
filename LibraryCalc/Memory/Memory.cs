using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalc.Mem
{
    public class Memory
    {
        // memoryItems жагсаалт нь MemoryItem обьектуудыг хадгалдаг хувийн хувьсагч.
        public List<MemoryItem> memoryItems { get; private set; }

        public Memory() { 
            this.memoryItems = new List<MemoryItem>();
        }
        /// <summary>
        /// Тухайн утгыг санах ойн жагсаалт руу хадгалах.
        /// </summary>
        /// <param name="value">Хадгалах утга</param>
        public void Save(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        /// <summary>
        /// Санах ойн жагсаалт дахь бүх MemoryItem обьектуудыг буцаах.
        /// </summary>
        /// <returns>MemoryItem объектуудын жагсаалт</returns>
        public List<MemoryItem> PrintMemoryItems()
        {
            return memoryItems;
        }
        

        /// <summary>
        /// Тухайн индексийн санах ойн элементийг авах.
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns>MemoryItem объект эсвэл null</returns>

        public MemoryItem? GetItem(int index)
        {
            // Хэрэв индекс зөв байвал тухайн индексийн объект буцаана.
            if (index >= 0 && index < memoryItems.Count)
                return memoryItems[index];
            else
                // Хэрэв индекс буруу байвал null буцаана.
                return null;
        }
        /// <summary>
        /// Санах ойг цэвэрлэх.
        /// </summary>
        public void Clear()
        {
            // memoryItems жагсаалтыг цэвэрлэх.
            memoryItems.Clear();
        }

        public void clearItem(MemoryItem m)
        {
            memoryItems.Remove(m);

        }
    }
}
