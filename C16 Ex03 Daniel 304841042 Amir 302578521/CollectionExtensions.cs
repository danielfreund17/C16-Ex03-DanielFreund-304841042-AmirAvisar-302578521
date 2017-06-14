using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public static class CollectionExtensions
    {
        public static T[] ToArray<T>(this IEnumerable<T> i_Source)
        {
            List<T> list = new List<T>();
            foreach (T item in i_Source)
            {
                list.Add(item);
            }

            return list.ToArray();
        }
    }
}
