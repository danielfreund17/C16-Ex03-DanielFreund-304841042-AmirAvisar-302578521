﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class StatusLikedBySorter : StatusSorter
    {
        public StatusLikedBySorter(ListBox i_ListBox) : base(i_ListBox)
        {
        }

        public StatusLikedBySorter()
        {
        }

        public override void Sort()
        {
            List<Status> statuses = new List<Status>();
            foreach (object obj in m_ListBox.Items)
            {
                statuses.Add((Status)obj);
            }

            statuses = statuses.OrderBy(o => o.LikedBy.Count).ToList();
            m_ListBox.Invoke(new Action(() => m_ListBox.Items.Clear()));
            m_ListBox.Invoke(new Action(() => m_ListBox.Items.AddRange(statuses.ToArray())));
        }
    }
}
