using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class MyAlbum
    {
        public string Name { get; private set; }

        public string ID { get; private set; }

        public int AmountOfLikes { get; set; }

        public string PictureURL { get; set; }

        public DateTime? DateTime { get; set; }

        public MyAlbum(string i_Name, string i_ID)
        {
            Name = i_Name;
            ID = i_ID;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
