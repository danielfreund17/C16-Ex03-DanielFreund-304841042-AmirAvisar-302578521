using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class AppAlbums : IEnumerable<MyAlbum>
    {
        private List<MyAlbum> m_Albums;

        public AppAlbums(List<MyAlbum> i_Album)
        {
            m_Albums = i_Album;
        }

        public IEnumerator<MyAlbum> GetEnumerator()
        {
            foreach(MyAlbum album in m_Albums)
            {
                yield return album;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<MyAlbum>)this).GetEnumerator();
        }
    }
}
