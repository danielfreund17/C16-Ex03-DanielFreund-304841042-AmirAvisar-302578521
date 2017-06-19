using System;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public class AppLogic : IStatusLike
    {
        private readonly string m_AccessToken = "1056060501156503";
        private string m_UserId;

        public event Action<string> ReportOnLoadingProfilePicture;

        public User LoggedInUser { get; private set; }

        public List<MyEvents> MyEvents { get; private set; }

        public AppAlbums MyAlbums { get; private set; }

        internal bool Login()
        {
            bool loggedIn = false;
            LoginResult result = FacebookService.Login(
                m_AccessToken,
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event");
            if (!string.IsNullOrEmpty(result.LoggedInUser.Name))
            {
                loggedIn = true;
                LoggedInUser = result.LoggedInUser;
                string pictureUrl = LoggedInUser.PictureLargeURL;
                notifyUIElementsToUpdateProfilePic(pictureUrl);

                this.m_UserId = LoggedInUser.Id;
            }

            return loggedIn;
        }

        private void notifyUIElementsToUpdateProfilePic(string i_PictureUrl)
        {
            if(this.ReportOnLoadingProfilePicture != null)
            {
                ReportOnLoadingProfilePicture.Invoke(i_PictureUrl);
            }
        }

        internal bool PostStatus(string i_Status)
        {
            bool isStatusPosted = false;
            if (i_Status.Length > 0)
            {
                LoggedInUser.PostStatus(i_Status);
                isStatusPosted = true;
            }

            return isStatusPosted;
        }

        internal AppAlbums GetAlbums()
        {
            string pictureURl = string.Empty;
            List<MyAlbum> albumList = new List<MyAlbum>();
            FacebookObjectCollection<Album> userAlbums = LoggedInUser.Albums;
            foreach(Album album in userAlbums)
            {
                if(album != null && album.Photos.Count > 0)
                {
                    albumList.Add(
                        new MyAlbum(
                            album.Name,
                            album.Id));
                }
            }

            this.MyAlbums = new AppAlbums(albumList);
            return this.MyAlbums;
        }

        internal List<IEventAdapter> GetEventsInfo()
        {
            FacebookObjectCollection<FacebookWrapper.ObjectModel.Event> myEvents = LoggedInUser.Events;
            List<IEventAdapter> adaptedEvents = new List<IEventAdapter>();
            foreach(Event ev in myEvents)
            {
                adaptedEvents.Add(new EventAdapter { Event = ev });
            }

            return adaptedEvents;
        }

        internal int GetMostLikedPicture(string o_Id, out string o_PictureUrl, out DateTime? o_DateTime)
        {
            Album album = LoggedInUser.Albums.Find(alb => alb.Id == o_Id);
            int amountOfLikes = 0;
            DateTime? date = null;
            int likes;
            string pictureUrl = album.Photos[0].PictureThumbURL;
            foreach(Photo photo in album.Photos)
            {
                likes = photo.LikedBy.Count;
                if(likes > amountOfLikes)
                {
                    amountOfLikes = likes;
                    pictureUrl = photo.PictureThumbURL;
                    date = photo.CreatedTime;
                }
            }

            o_DateTime = date;
            o_PictureUrl = pictureUrl;
            return amountOfLikes;
        }

        internal FacebookObjectCollection<Status> GetStatuses()
        {
            FacebookObjectCollection<Status> myStatuses = LoggedInUser.Statuses;
            return myStatuses;
        }

        public void LikeStatus(Status i_Status)
        {
            i_Status.Like();
        }
    }
}