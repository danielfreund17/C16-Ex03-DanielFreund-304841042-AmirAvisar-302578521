using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public partial class UserInterface : Form
    {
        private WaitingForm m_WaitingForm = new WaitingForm();
        private AppLogic m_AppActions = new AppLogic();
        private Dictionary<string, MyAlbum> m_AlbumDictionary = new Dictionary<string, MyAlbum>();
        private StatusSorter m_StatusSorter;

        public UserInterface()
        {
            InitializeComponent();
            this.CenterToScreen();
            FacebookWrapper.FacebookService.s_CollectionLimit = 50000;
            hideControls();
            handleLoginButtonEffect();
            this.MaximizeBox = false;
            this.m_AppActions.ReportOnLoadingProfilePicture += this.loadProfilePicture;
        }

        private void handleLoginButtonEffect()
        {
            m_Timer = new System.Windows.Forms.Timer();
            m_Timer.Interval = 100;
            m_Color = Color.Blue;
            m_Timer.Tick += timer_Tick;
        }

        private void hideControls()
        {
            this.m_TabHome.Controls.Remove(m_TabPagePostStatus);
            this.m_TabHome.Controls.Remove(m_TabPagePictureLikes);
            this.m_TabHome.Controls.Remove(m_TabEvent);
            this.m_TabHome.Controls.Remove(m_TabLikeStatus);
            this.m_TabHome.Controls.Remove(m_TabPages);
            this.m_ListBoxAlbums.Hide();
            this.m_ListBoxEvents.Hide();
            this.m_ListBoxStatuses.Hide();
            this.m_LabelEvents.Hide();
            this.m_LabelAlbums.Hide();
            this.m_LabelCreatedTimeTopic.Hide();
            this.m_ButtonLikeSelectedStatus.Hide();
            this.m_ButtonLikeSelectedStatus.Enabled = false;
            m_PanelEvents.Hide();
            m_ListBoxPages.Hide();
            m_PanelPages.Hide();
            m_PagesLabel.Hide();
            this.m_LabelShowBy.Hide();
            this.m_ListBoxShowBy.Hide();
        }

        private void m_LogginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool loginSuccess = m_AppActions.Login();
                if (loginSuccess)
                {
                    m_PictureBoxProfile.Hide();
                    addTabs();
                    MessageBox.Show(string.Format("Successfully logged in as {0}", m_AppActions.LoggedInUser.Name));
                    m_LogginButton.Enabled = false;
                    m_LabelLoggin.Text = string.Format(
@"Hi {0}
Please use the tabs in order to navigate",
m_AppActions.LoggedInUser.Name);
                    m_PictureBoxProfile.Show();
                    AppLogger.Instance.WriteToLog(
                        MethodBase.GetCurrentMethod().Name + 
                        "][USER:" + m_AppActions.LoggedInUser.Name +
                        "]",
                        "User Logged In Succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void loadProfilePicture(string i_PictureURL)
        {
            m_PictureBoxProfile.LoadAsync(i_PictureURL);
        }

        private void addTabs()
        {
            this.m_TabHome.Controls.Add(m_TabPagePostStatus);
            this.m_TabHome.Controls.Add(m_TabLikeStatus);
            this.m_TabHome.Controls.Add(m_TabPagePictureLikes);
            this.m_TabHome.Controls.Add(m_TabEvent);
            this.m_TabHome.Controls.Add(m_TabPages);        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            m_Alpha += 10;
            m_Color = Color.FromArgb(m_Alpha, 50, 50, 100);
            m_LogginButton.BackColor = m_Color;
            if (m_Alpha > 50)
            {
                m_Timer.Stop();
            }

            Invalidate();
        }

        private void m_LogginButton_MouseHover(object sender, EventArgs e)
        {
            m_Timer.Start();
            m_Alpha = 0;
        }

        private void m_LogginButton_MouseLeave(object sender, EventArgs e)
        {
            m_Timer.Stop();
            m_Alpha = 0;
            m_Color = BackColor;
            m_LogginButton.BackColor = Color.PowderBlue;
            Invalidate();
        }

        private void m_LogginButton_Paint(object sender, PaintEventArgs e)
        {
            if (m_Alpha > 0)
            {
                using (Brush b = new SolidBrush(m_Color))
                {
                    e.Graphics.FillRectangle(b, this.ClientRectangle);
                }
            }
        }

        private void m_ButtonPost_Click(object sender, EventArgs e)
        {
            try
            {
                bool isPosted = m_AppActions.PostStatus(m_TextBoxPost.Text);
                if (isPosted)
                {
                    MessageBox.Show("Status posted successfully!");
                    AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, "user posted status.");
                }
                else
                {
                    MessageBox.Show("You must enter text in order to post.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                this.m_TextBoxPost.Text = string.Empty;
            }
        }

        private void m_ButtonPictureLikes_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchAlbums);
            thread.Start();
        }

        private void fetchAlbums()
        {
            string pictureUrl = string.Empty;
            try
            {
                Thread waitingFormThread = new Thread(new ThreadStart(this.handleWatingForm));
                waitingFormThread.Start();
                AppAlbums albums = m_AppActions.GetAlbums();
                this.m_ListBoxAlbums.Invoke(new Action(() => this.m_ListBoxAlbums.Items.AddRange(albums.ToArray())));
                this.m_ListBoxAlbums.Invoke(new Action(() => this.m_ListBoxAlbums.Show()));
                this.m_ListBoxAlbums.Invoke(new Action(() => this.m_LabelAlbums.Show()));
                this.m_ButtonPictureLikes.Invoke(new Action(() => this.m_ButtonPictureLikes.Enabled = false));
                hideWaitingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void m_ButtonEvents_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchEvents);
            thread.Start();
        }

        private void fetchEvents()
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(this.handleWatingForm));
                thread.Start();
                List<IEventAdapter> myEvents = this.m_AppActions.GetEventsInfo();
                invokeEventsControls(myEvents);
                hideWaitingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void invokeEventsControls(List<IEventAdapter> i_MyEvents)
        {
            this.m_ButtonEvents.Invoke(new Action(() => this.m_ButtonEvents.Enabled = false));
            m_LabelEvents.Invoke(new Action(() => m_LabelEvents.Show()));
            m_ListBoxEvents.Invoke(new Action(() => m_ListBoxEvents.Show()));
            m_ListBoxEvents.Invoke(new Action(() => iEventAdapterBindingSource.DataSource = i_MyEvents));
            m_PanelEvents.Invoke(new Action(() => m_PanelEvents.Show()));
        }

        private void m_ListBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_ListBoxAlbums.SelectedItems.Count == 1)
            {
                MyAlbum selectedAlbum = this.m_ListBoxAlbums.SelectedItem as MyAlbum;
                Thread thread = new Thread(() =>
                {
                    fetchAmountOfLikes(selectedAlbum);
                });

                thread.Start();
            }
        }

        private void fetchAmountOfLikes(MyAlbum i_SelectedAlbum)
        {
            try
            {
                int amountOfLikes;
                string pictureUrl;
                DateTime? dateTime = null;
                Thread thread = new Thread(new ThreadStart(this.handleWatingForm));
                thread.Start();
                getPictureInfo(out amountOfLikes, out pictureUrl, out dateTime, i_SelectedAlbum);
                updateRelevantLabelsPictureLikes(pictureUrl, dateTime, amountOfLikes);
                hideWaitingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void updateRelevantLabelsPictureLikes(string i_PictureUrl, DateTime? i_DateTime, int i_AmountOfLikes)
        {
            this.m_PictureBoxPictureLikes.LoadAsync(i_PictureUrl);
            this.m_LabelCreatedTime.Invoke(new Action(() => this.m_LabelCreatedTime.Text =
                i_DateTime.ToString() == string.Empty ? "No Information" : i_DateTime.ToString()));
            this.m_LabelCreatedTimeTopic.Invoke(new Action(() => this.m_LabelCreatedTimeTopic.Show()));
            this.m_PictureBoxPictureLikes.SizeMode = PictureBoxSizeMode.StretchImage;
            m_LabelPictureLikes.Invoke(new Action(() => m_LabelPictureLikes.Text = string.Format(
            @"Your most liked picture has {0} likes!", i_AmountOfLikes)));
        }

        private void getPictureInfo(out int o_AmountOfLikes, out string o_PictureUrl, out DateTime? o_DateTime, MyAlbum o_SelectedAlbum)
        {
            string id = o_SelectedAlbum.ID;
            if (!m_AlbumDictionary.ContainsKey(id))
            {
                o_AmountOfLikes = m_AppActions.GetMostLikedPicture(id, out o_PictureUrl, out o_DateTime);
                o_SelectedAlbum.AmountOfLikes = o_AmountOfLikes;
                o_SelectedAlbum.PictureURL = o_PictureUrl;
                o_SelectedAlbum.DateTime = o_DateTime;
                m_AlbumDictionary.Add(id, o_SelectedAlbum);
            }
            else
            {
                o_AmountOfLikes = m_AlbumDictionary[id].AmountOfLikes;
                o_PictureUrl = m_AlbumDictionary[id].PictureURL;
                o_DateTime = m_AlbumDictionary[id].DateTime;
            }
        }

        private void m_ButtonGetStatus_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchStatuses);
            thread.Start();
            this.m_ButtonGetStatus.Enabled = false;
        }

        private void fetchStatuses()
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(this.handleWatingForm));
                thread.Start();
                FacebookObjectCollection<Status> statuses = m_AppActions.GetStatuses();
                getSortTypes();
                this.m_ListBoxStatuses.Invoke(new Action(() => m_ListBoxStatuses.DisplayMember = "Message"));
                this.m_ListBoxStatuses.Invoke(new Action(() =>
                {
                    foreach (Status status in statuses)
                    {
                        this.m_ListBoxStatuses.Items.Add(status);
                    }
                }));

                showStatusControls();
                hideWaitingForm();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void hideWaitingForm()
        {
            try
            {
                m_WaitingForm.Invoke(new MethodInvoker(() => m_WaitingForm.Hide()));
            }
            catch (Exception)
            {
            }
        }

        private void showStatusControls()
        {
            this.m_ListBoxStatuses.Invoke(new Action(() => m_ListBoxStatuses.Show()));
            this.m_ButtonLikeSelectedStatus.Invoke(new Action(() => m_ButtonLikeSelectedStatus.Show()));
            this.m_ListBoxShowBy.Invoke(new Action(() => m_ListBoxShowBy.Show()));
            this.m_LabelShowBy.Invoke(new Action(() => m_LabelShowBy.Show()));
        }

        private void getSortTypes()
        {
            m_ListBoxShowBy.Invoke(new Action(() => m_ListBoxShowBy.DisplayMember = "Name"));
            m_ListBoxShowBy.Invoke(new Action(() =>
           {
               foreach (eSortTypes sorter in Enum.GetValues(typeof(eSortTypes)))
               {
                   m_ListBoxShowBy.Items.Add(new EnumWrapper(sorter, sorter.GetName()));
               }
           }));
        }

        private void m_ListBoxStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_ListBoxStatuses.SelectedItems.Count == 1)
            {
                m_ButtonLikeSelectedStatus.Enabled = true;
            }
            else
            {
                m_ButtonLikeSelectedStatus.Enabled = false;
            }
        }

        private void m_ButtonLikeSelectedStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status status = m_ListBoxStatuses.SelectedItem as Status;
                IStatusLike statusLiker = new StatusProxy { AppLogic = m_AppActions };
                statusLiker.LikeStatus(status);
                MessageBox.Show("You have liked a Status!");
            }
            catch (LikeStatusException statusException)
            {
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, statusException.Message);
                MessageBox.Show(statusException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }           
        }

        private void handleWatingForm()
        {
            m_WaitingForm.Location = this.Location;
            m_WaitingForm.TopMost = true;
            m_WaitingForm.ShowDialog();
            Application.DoEvents();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, "User logged off");
        }

        private void m_ButtonGetPages_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchPages);
            thread.Start();           
        }

        private void fetchPages()
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(this.handleWatingForm));
                thread.Start();
                pageBindingSource.DataSource = m_AppActions.LoggedInUser.LikedPages;
                invokePagesControls();
                hideWaitingForm();
            }
            catch(Exception ex)
            {
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void invokePagesControls()
        {
            m_PanelPages.Invoke(new Action(() => m_PanelPages.Show()));
            m_PagesLabel.Invoke(new Action(() => m_PagesLabel.Show()));
            m_ListBoxPages.Invoke(new Action(() => m_ListBoxPages.Show()));
            m_ButtonGetPages.Invoke(new Action(() => m_ButtonGetPages.Enabled = false));
        }

        private void m_GoogleSearcher_Click(object sender, EventArgs e)
        {
            if (this.m_ListBoxEvents.SelectedItems.Count == 1)
            {
                IEventAdapter myEvent = m_ListBoxEvents.SelectedItem as IEventAdapter;
                string name = myEvent.ToString();
                StringBuilder sb = new StringBuilder();
                sb.Append("http://www.google.com/search?q=");
                sb.Append(name);
                string url = sb.ToString();
                WebSearcher searcher = new WebSearcher();
                searcher.Url = url;
                searcher.ShowDialog();
            }
        }

        private void m_ListBoxShowBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_ListBoxShowBy.SelectedItems.Count == 1)
            {
                eSortTypes selectedSort = (eSortTypes)((EnumWrapper)m_ListBoxShowBy.SelectedItem).eEnumValue;
                m_StatusSorter = StatusSorterFactory.GetSorter(selectedSort);
                m_StatusSorter.ListBoxStatus = this.m_ListBoxStatuses;
                Thread thread = new Thread(sortStatuses);
                thread.Start();        
            }
        }

        private void sortStatuses()
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(this.handleWatingForm));
                thread.Start();
                m_StatusSorter.Sort();
                hideWaitingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Instance.WriteToLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}