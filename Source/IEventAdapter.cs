using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public interface IEventAdapter
    {
        Event Event { get; set; }

        int AttendingUsers { get; }

        DateTime StartTime { get; }

        DateTime EndTime { get; }

        string Description { get; }
    }
}
