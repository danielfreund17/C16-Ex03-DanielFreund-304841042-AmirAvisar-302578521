using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class LikeStatusException : Exception
    {
        public LikeStatusException()
        {
        }

        public LikeStatusException(string i_Message)
            : base(i_Message)
        {
        }

        public LikeStatusException(string i_Message, Exception i_InnerException)
            : base(i_Message, i_InnerException)
        {
        }
    }
}
