using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class StatusProxy : IStatusLike
    {
        public AppLogic AppLogic { get; set; }

        public void LikeStatus(Status i_Status)
        {
            if (!i_Status.Message.Contains("test") && i_Status.LikedBy.Count < 20)
            {
                AppLogic.LikeStatus(i_Status);
            }
            else
            {
                if (i_Status.Message.Contains("test"))
                {
                    throw new LikeStatusException("I'm not allowing to like test posts!!!");
                }
                else
                {
                    throw new LikeStatusException("Find a post with less likes, Don't follow the herd!");
                }
            }
        }
    }
}
