using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum i_Enum)
        {
            Type type = i_Enum.GetType();
            MemberInfo[] memInfo = type.GetMember(i_Enum.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(Description), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((Description)attrs[0]).m_Text;
                }
            }

            return i_Enum.ToString();
        }
    }
}
