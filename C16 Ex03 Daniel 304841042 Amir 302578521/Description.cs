using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class Description : Attribute
    {
        public string m_Text;

        public Description(string i_Text)
        {
            m_Text = i_Text;
        }
    }
}
