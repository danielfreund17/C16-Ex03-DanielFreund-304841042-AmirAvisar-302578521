using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class EventAdapter : IEventAdapter
    {
        private Event m_Event;

        public int AttendingUsers
        {
            get
            {
                try
                {
                    int count = m_Event.AttendingUsers.Count;
                    return count;
                }
                catch(Exception)
                {
                    return 0;
                }
            }
        }

        public string Description
        {
            get
            {
                return m_Event.Description;
            }
        }

        public DateTime EndTime
        {
            get
            {
                try
                {
                    DateTime time = m_Event.EndTime.Value;
                    return time;
                }
                catch (Exception)
                {
                    return DateTime.Now;
                } 
            }
        }

        public Event Event
        {
            get
            {
                return m_Event;
            }

            set
            {
                m_Event = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                try
                {
                    DateTime time = m_Event.EndTime.Value;
                    return time;
                }
                catch (Exception)
                {
                    return DateTime.Now;
                }
            }
        }

        public override string ToString()
        {
            return m_Event.Name;
        }
    }
}
