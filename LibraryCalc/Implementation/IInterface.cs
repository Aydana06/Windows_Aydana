using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalc.Implementation
{
    internal interface IInterface
    {
        /// <summary>
        /// Тухайн объектоос тодорхой утга нэмэх арга.
        /// </summary>
        /// <param name="value">Нэмэх утга</param>
        void Add(double value);
        /// <summary>
        /// Тухайн объектоос тодорхой утга хасах арга.
        /// </summary>
        /// <param name="value">Хасах утга</param>
        void Subtract(double value);

    }
}
