using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCalc.Implementation;


namespace LibraryCalc.Mem
{
    public class MemoryItem(double value) : IInterface
    {
        // `Value` хувьсагч нь зөвхөн унших боломжтой бөгөөд эхний утгыг анхдагч байдлаар авна.
        public double Value { get; private set; } = value;
        /// <summary>
        /// Утгыг нэмэх.
        /// </summary>
        /// <param name="result">Нэмэх утга</param>
        public void Add(double result)
        {
            Value += result;
        }

        /// <summary>
        /// Утгаас хасах.
        /// </summary>
        /// <param name="result">Хасах утга</param>
        public void Subtract(double result)
        {
            Value -= result;
        }
    }
}
