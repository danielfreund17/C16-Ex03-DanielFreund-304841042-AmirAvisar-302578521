using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class EnumWrapper
    {
        public Enum eEnumValue { get; set; }

        public string Name { get; set; }

        public EnumWrapper(Enum i_EnumValue, string i_Name)
        {
            eEnumValue = i_EnumValue;
            Name = i_Name;
        }
    }
}
