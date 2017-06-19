using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public enum eSortTypes
    {
        Name,
        [Description("Created Time")]
        CreatedTime,
        [Description("Liked By")]
        LikedBy
    }

    public abstract class StatusSorter
    {
        protected ListBox m_ListBox;

        public StatusSorter(ListBox i_ListBox)
        {
            m_ListBox = i_ListBox;
        }

        public StatusSorter()
        {
        }

        public ListBox ListBoxStatus
        {
            set { m_ListBox = value; }
        }

        public abstract void Sort();
    }
}
