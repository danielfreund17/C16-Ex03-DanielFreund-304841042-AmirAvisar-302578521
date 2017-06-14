using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public static class StatusSorterFactory
    {
        public static StatusSorter GetSorter(eSortTypes i_SortType)
        {
            StatusSorter sorter = null;
            switch (i_SortType)
            {
                case eSortTypes.CreatedTime:
                    sorter = new StatusCreatedSorter();
                    break;
                case eSortTypes.LikedBy:
                    sorter = new StatusLikedBySorter();
                    break;
                default:
                    sorter = new StatusNameSorter();
                    break;
            }

            return sorter;
        }
    }
}
