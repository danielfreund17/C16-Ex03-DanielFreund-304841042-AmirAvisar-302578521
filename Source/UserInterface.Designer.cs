using System.Drawing;
using System.Windows.Forms;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Timer m_Timer;
        private int m_Alpha;
        private Color m_Color;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label talkingAboutCountLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label attendingUsersLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.m_TabHome = new System.Windows.Forms.TabControl();
            this.m_TabPageLogin = new System.Windows.Forms.TabPage();
            this.m_LabelLoggin = new System.Windows.Forms.Label();
            this.m_PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.m_LogginButton = new System.Windows.Forms.Button();
            this.m_TabLikeStatus = new System.Windows.Forms.TabPage();
            this.m_LabelShowBy = new System.Windows.Forms.Label();
            this.m_ListBoxShowBy = new System.Windows.Forms.ListBox();
            this.m_ButtonLikeSelectedStatus = new System.Windows.Forms.Button();
            this.m_ListBoxStatuses = new System.Windows.Forms.ListBox();
            this.m_ButtonGetStatus = new System.Windows.Forms.Button();
            this.m_TabPagePostStatus = new System.Windows.Forms.TabPage();
            this.m_ButtonPost = new System.Windows.Forms.Button();
            this.m_TextBoxPost = new System.Windows.Forms.TextBox();
            this.m_TabPagePictureLikes = new System.Windows.Forms.TabPage();
            this.m_LabelCreatedTime = new System.Windows.Forms.Label();
            this.m_LabelCreatedTimeTopic = new System.Windows.Forms.Label();
            this.m_LabelAlbums = new System.Windows.Forms.Label();
            this.m_ListBoxAlbums = new System.Windows.Forms.ListBox();
            this.m_LabelPictureLikes = new System.Windows.Forms.Label();
            this.m_PictureBoxPictureLikes = new System.Windows.Forms.PictureBox();
            this.m_ButtonPictureLikes = new System.Windows.Forms.Button();
            this.m_TabEvent = new System.Windows.Forms.TabPage();
            this.m_PanelEvents = new System.Windows.Forms.Panel();
            this.m_GoogleSearcher = new System.Windows.Forms.Button();
            this.attendingUsersTextBox = new System.Windows.Forms.TextBox();
            this.iEventAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_LabelEvents = new System.Windows.Forms.Label();
            this.m_ListBoxEvents = new System.Windows.Forms.ListBox();
            this.m_ButtonEvents = new System.Windows.Forms.Button();
            this.m_TabPages = new System.Windows.Forms.TabPage();
            this.m_PagesLabel = new System.Windows.Forms.Label();
            this.m_ButtonGetPages = new System.Windows.Forms.Button();
            this.m_ListBoxPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_PanelPages = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.talkingAboutCountTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            descriptionLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            talkingAboutCountLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            attendingUsersLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            this.m_TabHome.SuspendLayout();
            this.m_TabPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfile)).BeginInit();
            this.m_TabLikeStatus.SuspendLayout();
            this.m_TabPagePostStatus.SuspendLayout();
            this.m_TabPagePictureLikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPictureLikes)).BeginInit();
            this.m_TabEvent.SuspendLayout();
            this.m_PanelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iEventAdapterBindingSource)).BeginInit();
            this.m_TabPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.m_PanelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(7, 146);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(7, 273);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(66, 13);
            likesCountLabel.TabIndex = 4;
            likesCountLabel.Text = "Likes Count:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(7, 215);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // talkingAboutCountLabel
            // 
            talkingAboutCountLabel.AutoSize = true;
            talkingAboutCountLabel.Location = new System.Drawing.Point(7, 306);
            talkingAboutCountLabel.Name = "talkingAboutCountLabel";
            talkingAboutCountLabel.Size = new System.Drawing.Size(107, 13);
            talkingAboutCountLabel.TabIndex = 8;
            talkingAboutCountLabel.Text = "Talking About Count:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(7, 336);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 10;
            websiteLabel.Text = "Website:";
            // 
            // attendingUsersLabel
            // 
            attendingUsersLabel.AutoSize = true;
            attendingUsersLabel.Location = new System.Drawing.Point(13, 14);
            attendingUsersLabel.Name = "attendingUsersLabel";
            attendingUsersLabel.Size = new System.Drawing.Size(85, 13);
            attendingUsersLabel.TabIndex = 0;
            attendingUsersLabel.Text = "Attending Users:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(13, 40);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 2;
            descriptionLabel1.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(13, 92);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "End Time:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(13, 118);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 6;
            startTimeLabel.Text = "Start Time:";
            // 
            // m_TabHome
            // 
            this.m_TabHome.Controls.Add(this.m_TabPageLogin);
            this.m_TabHome.Controls.Add(this.m_TabLikeStatus);
            this.m_TabHome.Controls.Add(this.m_TabPagePostStatus);
            this.m_TabHome.Controls.Add(this.m_TabPagePictureLikes);
            this.m_TabHome.Controls.Add(this.m_TabEvent);
            this.m_TabHome.Controls.Add(this.m_TabPages);
            this.m_TabHome.Location = new System.Drawing.Point(1, 1);
            this.m_TabHome.Name = "m_TabHome";
            this.m_TabHome.SelectedIndex = 0;
            this.m_TabHome.Size = new System.Drawing.Size(613, 500);
            this.m_TabHome.TabIndex = 0;
            // 
            // m_TabPageLogin
            // 
            this.m_TabPageLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.m_TabPageLogin.Controls.Add(this.m_LabelLoggin);
            this.m_TabPageLogin.Controls.Add(this.m_PictureBoxProfile);
            this.m_TabPageLogin.Controls.Add(this.m_LogginButton);
            this.m_TabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.m_TabPageLogin.Name = "m_TabPageLogin";
            this.m_TabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabPageLogin.Size = new System.Drawing.Size(605, 474);
            this.m_TabPageLogin.TabIndex = 0;
            this.m_TabPageLogin.Text = "Login";
            // 
            // m_LabelLoggin
            // 
            this.m_LabelLoggin.AutoSize = true;
            this.m_LabelLoggin.Font = new System.Drawing.Font("Miriam Fixed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLoggin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_LabelLoggin.Location = new System.Drawing.Point(73, 246);
            this.m_LabelLoggin.Name = "m_LabelLoggin";
            this.m_LabelLoggin.Size = new System.Drawing.Size(0, 19);
            this.m_LabelLoggin.TabIndex = 5;
            this.m_LabelLoggin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_PictureBoxProfile
            // 
            this.m_PictureBoxProfile.Location = new System.Drawing.Point(220, 47);
            this.m_PictureBoxProfile.Name = "m_PictureBoxProfile";
            this.m_PictureBoxProfile.Size = new System.Drawing.Size(179, 172);
            this.m_PictureBoxProfile.TabIndex = 4;
            this.m_PictureBoxProfile.TabStop = false;
            // 
            // m_LogginButton
            // 
            this.m_LogginButton.BackColor = System.Drawing.Color.PowderBlue;
            this.m_LogginButton.Font = new System.Drawing.Font("Miriam", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LogginButton.Location = new System.Drawing.Point(225, 337);
            this.m_LogginButton.Name = "m_LogginButton";
            this.m_LogginButton.Size = new System.Drawing.Size(179, 68);
            this.m_LogginButton.TabIndex = 3;
            this.m_LogginButton.Text = "Login";
            this.m_LogginButton.UseVisualStyleBackColor = false;
            this.m_LogginButton.Click += new System.EventHandler(this.m_LogginButton_Click);
            this.m_LogginButton.Paint += new System.Windows.Forms.PaintEventHandler(this.m_LogginButton_Paint);
            this.m_LogginButton.MouseLeave += new System.EventHandler(this.m_LogginButton_MouseLeave);
            this.m_LogginButton.MouseHover += new System.EventHandler(this.m_LogginButton_MouseHover);
            // 
            // m_TabLikeStatus
            // 
            this.m_TabLikeStatus.BackColor = System.Drawing.Color.PaleTurquoise;
            this.m_TabLikeStatus.Controls.Add(this.m_LabelShowBy);
            this.m_TabLikeStatus.Controls.Add(this.m_ListBoxShowBy);
            this.m_TabLikeStatus.Controls.Add(this.m_ButtonLikeSelectedStatus);
            this.m_TabLikeStatus.Controls.Add(this.m_ListBoxStatuses);
            this.m_TabLikeStatus.Controls.Add(this.m_ButtonGetStatus);
            this.m_TabLikeStatus.Location = new System.Drawing.Point(4, 22);
            this.m_TabLikeStatus.Name = "m_TabLikeStatus";
            this.m_TabLikeStatus.Size = new System.Drawing.Size(605, 474);
            this.m_TabLikeStatus.TabIndex = 4;
            this.m_TabLikeStatus.Text = "Like A Status";
            // 
            // m_LabelShowBy
            // 
            this.m_LabelShowBy.AutoSize = true;
            this.m_LabelShowBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelShowBy.Location = new System.Drawing.Point(34, 344);
            this.m_LabelShowBy.Name = "m_LabelShowBy";
            this.m_LabelShowBy.Size = new System.Drawing.Size(97, 24);
            this.m_LabelShowBy.TabIndex = 4;
            this.m_LabelShowBy.Text = "Show By:";
            // 
            // m_ListBoxShowBy
            // 
            this.m_ListBoxShowBy.FormattingEnabled = true;
            this.m_ListBoxShowBy.Location = new System.Drawing.Point(7, 385);
            this.m_ListBoxShowBy.Name = "m_ListBoxShowBy";
            this.m_ListBoxShowBy.Size = new System.Drawing.Size(168, 69);
            this.m_ListBoxShowBy.TabIndex = 3;
            this.m_ListBoxShowBy.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxShowBy_SelectedIndexChanged);
            // 
            // m_ButtonLikeSelectedStatus
            // 
            this.m_ButtonLikeSelectedStatus.BackColor = System.Drawing.Color.PowderBlue;
            this.m_ButtonLikeSelectedStatus.Location = new System.Drawing.Point(202, 308);
            this.m_ButtonLikeSelectedStatus.Name = "m_ButtonLikeSelectedStatus";
            this.m_ButtonLikeSelectedStatus.Size = new System.Drawing.Size(214, 62);
            this.m_ButtonLikeSelectedStatus.TabIndex = 2;
            this.m_ButtonLikeSelectedStatus.Text = "Like Selected Status";
            this.m_ButtonLikeSelectedStatus.UseVisualStyleBackColor = false;
            this.m_ButtonLikeSelectedStatus.Click += new System.EventHandler(this.m_ButtonLikeSelectedStatus_Click);
            // 
            // m_ListBoxStatuses
            // 
            this.m_ListBoxStatuses.FormattingEnabled = true;
            this.m_ListBoxStatuses.Location = new System.Drawing.Point(93, 27);
            this.m_ListBoxStatuses.Name = "m_ListBoxStatuses";
            this.m_ListBoxStatuses.Size = new System.Drawing.Size(449, 264);
            this.m_ListBoxStatuses.TabIndex = 1;
            this.m_ListBoxStatuses.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxStatuses_SelectedIndexChanged);
            // 
            // m_ButtonGetStatus
            // 
            this.m_ButtonGetStatus.BackColor = System.Drawing.Color.PowderBlue;
            this.m_ButtonGetStatus.Location = new System.Drawing.Point(202, 385);
            this.m_ButtonGetStatus.Name = "m_ButtonGetStatus";
            this.m_ButtonGetStatus.Size = new System.Drawing.Size(214, 63);
            this.m_ButtonGetStatus.TabIndex = 0;
            this.m_ButtonGetStatus.Text = "Get My Statuses";
            this.m_ButtonGetStatus.UseVisualStyleBackColor = false;
            this.m_ButtonGetStatus.Click += new System.EventHandler(this.m_ButtonGetStatus_Click);
            // 
            // m_TabPagePostStatus
            // 
            this.m_TabPagePostStatus.BackColor = System.Drawing.Color.PaleTurquoise;
            this.m_TabPagePostStatus.Controls.Add(this.m_ButtonPost);
            this.m_TabPagePostStatus.Controls.Add(this.m_TextBoxPost);
            this.m_TabPagePostStatus.Location = new System.Drawing.Point(4, 22);
            this.m_TabPagePostStatus.Name = "m_TabPagePostStatus";
            this.m_TabPagePostStatus.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabPagePostStatus.Size = new System.Drawing.Size(605, 474);
            this.m_TabPagePostStatus.TabIndex = 1;
            this.m_TabPagePostStatus.Text = "Post Status";
            // 
            // m_ButtonPost
            // 
            this.m_ButtonPost.BackColor = System.Drawing.Color.PowderBlue;
            this.m_ButtonPost.Font = new System.Drawing.Font("Miriam", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonPost.Location = new System.Drawing.Point(221, 296);
            this.m_ButtonPost.Name = "m_ButtonPost";
            this.m_ButtonPost.Size = new System.Drawing.Size(172, 70);
            this.m_ButtonPost.TabIndex = 3;
            this.m_ButtonPost.Text = "Post Status!";
            this.m_ButtonPost.UseVisualStyleBackColor = false;
            this.m_ButtonPost.Click += new System.EventHandler(this.m_ButtonPost_Click);
            // 
            // m_TextBoxPost
            // 
            this.m_TextBoxPost.Location = new System.Drawing.Point(135, 190);
            this.m_TextBoxPost.Multiline = true;
            this.m_TextBoxPost.Name = "m_TextBoxPost";
            this.m_TextBoxPost.Size = new System.Drawing.Size(357, 44);
            this.m_TextBoxPost.TabIndex = 2;
            // 
            // m_TabPagePictureLikes
            // 
            this.m_TabPagePictureLikes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.m_TabPagePictureLikes.Controls.Add(this.m_LabelCreatedTime);
            this.m_TabPagePictureLikes.Controls.Add(this.m_LabelCreatedTimeTopic);
            this.m_TabPagePictureLikes.Controls.Add(this.m_LabelAlbums);
            this.m_TabPagePictureLikes.Controls.Add(this.m_ListBoxAlbums);
            this.m_TabPagePictureLikes.Controls.Add(this.m_LabelPictureLikes);
            this.m_TabPagePictureLikes.Controls.Add(this.m_PictureBoxPictureLikes);
            this.m_TabPagePictureLikes.Controls.Add(this.m_ButtonPictureLikes);
            this.m_TabPagePictureLikes.Location = new System.Drawing.Point(4, 22);
            this.m_TabPagePictureLikes.Name = "m_TabPagePictureLikes";
            this.m_TabPagePictureLikes.Size = new System.Drawing.Size(605, 474);
            this.m_TabPagePictureLikes.TabIndex = 2;
            this.m_TabPagePictureLikes.Text = "Most Liked Picture In Specific Album";
            // 
            // m_LabelCreatedTime
            // 
            this.m_LabelCreatedTime.AutoSize = true;
            this.m_LabelCreatedTime.Font = new System.Drawing.Font("Miriam", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelCreatedTime.Location = new System.Drawing.Point(359, 285);
            this.m_LabelCreatedTime.Name = "m_LabelCreatedTime";
            this.m_LabelCreatedTime.Size = new System.Drawing.Size(0, 21);
            this.m_LabelCreatedTime.TabIndex = 6;
            // 
            // m_LabelCreatedTimeTopic
            // 
            this.m_LabelCreatedTimeTopic.AutoSize = true;
            this.m_LabelCreatedTimeTopic.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelCreatedTimeTopic.Location = new System.Drawing.Point(388, 246);
            this.m_LabelCreatedTimeTopic.Name = "m_LabelCreatedTimeTopic";
            this.m_LabelCreatedTimeTopic.Size = new System.Drawing.Size(132, 24);
            this.m_LabelCreatedTimeTopic.TabIndex = 5;
            this.m_LabelCreatedTimeTopic.Text = "Created At:";
            // 
            // m_LabelAlbums
            // 
            this.m_LabelAlbums.AutoSize = true;
            this.m_LabelAlbums.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelAlbums.Location = new System.Drawing.Point(112, 9);
            this.m_LabelAlbums.Name = "m_LabelAlbums";
            this.m_LabelAlbums.Size = new System.Drawing.Size(88, 24);
            this.m_LabelAlbums.TabIndex = 4;
            this.m_LabelAlbums.Text = "Albums";
            // 
            // m_ListBoxAlbums
            // 
            this.m_ListBoxAlbums.FormattingEnabled = true;
            this.m_ListBoxAlbums.Location = new System.Drawing.Point(58, 39);
            this.m_ListBoxAlbums.Name = "m_ListBoxAlbums";
            this.m_ListBoxAlbums.Size = new System.Drawing.Size(219, 277);
            this.m_ListBoxAlbums.TabIndex = 3;
            this.m_ListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxAlbums_SelectedIndexChanged);
            // 
            // m_LabelPictureLikes
            // 
            this.m_LabelPictureLikes.AutoSize = true;
            this.m_LabelPictureLikes.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelPictureLikes.Location = new System.Drawing.Point(144, 349);
            this.m_LabelPictureLikes.Name = "m_LabelPictureLikes";
            this.m_LabelPictureLikes.Size = new System.Drawing.Size(0, 20);
            this.m_LabelPictureLikes.TabIndex = 2;
            // 
            // m_PictureBoxPictureLikes
            // 
            this.m_PictureBoxPictureLikes.InitialImage = null;
            this.m_PictureBoxPictureLikes.Location = new System.Drawing.Point(372, 39);
            this.m_PictureBoxPictureLikes.Name = "m_PictureBoxPictureLikes";
            this.m_PictureBoxPictureLikes.Size = new System.Drawing.Size(165, 136);
            this.m_PictureBoxPictureLikes.TabIndex = 1;
            this.m_PictureBoxPictureLikes.TabStop = false;
            // 
            // m_ButtonPictureLikes
            // 
            this.m_ButtonPictureLikes.BackColor = System.Drawing.Color.PowderBlue;
            this.m_ButtonPictureLikes.Location = new System.Drawing.Point(211, 387);
            this.m_ButtonPictureLikes.Name = "m_ButtonPictureLikes";
            this.m_ButtonPictureLikes.Size = new System.Drawing.Size(193, 61);
            this.m_ButtonPictureLikes.TabIndex = 0;
            this.m_ButtonPictureLikes.Text = "Press to Find out!";
            this.m_ButtonPictureLikes.UseVisualStyleBackColor = false;
            this.m_ButtonPictureLikes.Click += new System.EventHandler(this.m_ButtonPictureLikes_Click);
            // 
            // m_TabEvent
            // 
            this.m_TabEvent.AutoScroll = true;
            this.m_TabEvent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.m_TabEvent.Controls.Add(this.m_PanelEvents);
            this.m_TabEvent.Controls.Add(this.m_LabelEvents);
            this.m_TabEvent.Controls.Add(this.m_ListBoxEvents);
            this.m_TabEvent.Controls.Add(this.m_ButtonEvents);
            this.m_TabEvent.Location = new System.Drawing.Point(4, 22);
            this.m_TabEvent.Name = "m_TabEvent";
            this.m_TabEvent.Size = new System.Drawing.Size(605, 474);
            this.m_TabEvent.TabIndex = 3;
            this.m_TabEvent.Text = "Search Information Of Event";
            // 
            // m_PanelEvents
            // 
            this.m_PanelEvents.Controls.Add(this.m_GoogleSearcher);
            this.m_PanelEvents.Controls.Add(attendingUsersLabel);
            this.m_PanelEvents.Controls.Add(this.attendingUsersTextBox);
            this.m_PanelEvents.Controls.Add(descriptionLabel1);
            this.m_PanelEvents.Controls.Add(this.descriptionTextBox1);
            this.m_PanelEvents.Controls.Add(endTimeLabel);
            this.m_PanelEvents.Controls.Add(this.endTimeDateTimePicker);
            this.m_PanelEvents.Controls.Add(startTimeLabel);
            this.m_PanelEvents.Controls.Add(this.startTimeDateTimePicker);
            this.m_PanelEvents.Location = new System.Drawing.Point(7, 267);
            this.m_PanelEvents.Name = "m_PanelEvents";
            this.m_PanelEvents.Size = new System.Drawing.Size(575, 136);
            this.m_PanelEvents.TabIndex = 10;
            // 
            // m_GoogleSearcher
            // 
            this.m_GoogleSearcher.BackColor = System.Drawing.Color.PowderBlue;
            this.m_GoogleSearcher.Location = new System.Drawing.Point(352, 85);
            this.m_GoogleSearcher.Name = "m_GoogleSearcher";
            this.m_GoogleSearcher.Size = new System.Drawing.Size(159, 48);
            this.m_GoogleSearcher.TabIndex = 13;
            this.m_GoogleSearcher.Text = "Search Me In Google";
            this.m_GoogleSearcher.UseVisualStyleBackColor = false;
            this.m_GoogleSearcher.Click += new System.EventHandler(this.m_GoogleSearcher_Click);
            // 
            // attendingUsersTextBox
            // 
            this.attendingUsersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iEventAdapterBindingSource, "AttendingUsers", true));
            this.attendingUsersTextBox.Location = new System.Drawing.Point(104, 11);
            this.attendingUsersTextBox.Name = "attendingUsersTextBox";
            this.attendingUsersTextBox.Size = new System.Drawing.Size(200, 20);
            this.attendingUsersTextBox.TabIndex = 1;
            // 
            // iEventAdapterBindingSource
            // 
            this.iEventAdapterBindingSource.DataSource = typeof(C16_Ex03_Daniel_304841042_Amir_302578521.IEventAdapter);
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iEventAdapterBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(104, 37);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(445, 45);
            this.descriptionTextBox1.TabIndex = 3;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iEventAdapterBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(104, 88);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimeDateTimePicker.TabIndex = 5;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iEventAdapterBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(104, 114);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimeDateTimePicker.TabIndex = 7;
            // 
            // m_LabelEvents
            // 
            this.m_LabelEvents.AutoSize = true;
            this.m_LabelEvents.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelEvents.Location = new System.Drawing.Point(240, 9);
            this.m_LabelEvents.Name = "m_LabelEvents";
            this.m_LabelEvents.Size = new System.Drawing.Size(116, 24);
            this.m_LabelEvents.TabIndex = 0;
            this.m_LabelEvents.Text = "Event List";
            // 
            // m_ListBoxEvents
            // 
            this.m_ListBoxEvents.DataSource = this.iEventAdapterBindingSource;
            this.m_ListBoxEvents.FormattingEnabled = true;
            this.m_ListBoxEvents.Location = new System.Drawing.Point(71, 36);
            this.m_ListBoxEvents.Name = "m_ListBoxEvents";
            this.m_ListBoxEvents.Size = new System.Drawing.Size(459, 225);
            this.m_ListBoxEvents.TabIndex = 9;
            // 
            // m_ButtonEvents
            // 
            this.m_ButtonEvents.BackColor = System.Drawing.Color.PowderBlue;
            this.m_ButtonEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.m_ButtonEvents.Location = new System.Drawing.Point(234, 409);
            this.m_ButtonEvents.Name = "m_ButtonEvents";
            this.m_ButtonEvents.Size = new System.Drawing.Size(126, 57);
            this.m_ButtonEvents.TabIndex = 7;
            this.m_ButtonEvents.Text = "Get Events";
            this.m_ButtonEvents.UseVisualStyleBackColor = false;
            this.m_ButtonEvents.Click += new System.EventHandler(this.m_ButtonEvents_Click);
            // 
            // m_TabPages
            // 
            this.m_TabPages.BackColor = System.Drawing.Color.PaleTurquoise;
            this.m_TabPages.Controls.Add(this.m_PagesLabel);
            this.m_TabPages.Controls.Add(this.m_ButtonGetPages);
            this.m_TabPages.Controls.Add(this.m_ListBoxPages);
            this.m_TabPages.Controls.Add(this.m_PanelPages);
            this.m_TabPages.Location = new System.Drawing.Point(4, 22);
            this.m_TabPages.Name = "m_TabPages";
            this.m_TabPages.Size = new System.Drawing.Size(605, 474);
            this.m_TabPages.TabIndex = 5;
            this.m_TabPages.Text = "Liked Pages";
            // 
            // m_PagesLabel
            // 
            this.m_PagesLabel.AutoSize = true;
            this.m_PagesLabel.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PagesLabel.Location = new System.Drawing.Point(73, 10);
            this.m_PagesLabel.Name = "m_PagesLabel";
            this.m_PagesLabel.Size = new System.Drawing.Size(122, 24);
            this.m_PagesLabel.TabIndex = 3;
            this.m_PagesLabel.Text = "Pages List";
            // 
            // m_ButtonGetPages
            // 
            this.m_ButtonGetPages.BackColor = System.Drawing.Color.PowderBlue;
            this.m_ButtonGetPages.Location = new System.Drawing.Point(224, 399);
            this.m_ButtonGetPages.Name = "m_ButtonGetPages";
            this.m_ButtonGetPages.Size = new System.Drawing.Size(163, 55);
            this.m_ButtonGetPages.TabIndex = 2;
            this.m_ButtonGetPages.Text = "Get Pages";
            this.m_ButtonGetPages.UseVisualStyleBackColor = false;
            this.m_ButtonGetPages.Click += new System.EventHandler(this.m_ButtonGetPages_Click);
            // 
            // m_ListBoxPages
            // 
            this.m_ListBoxPages.DataSource = this.pageBindingSource;
            this.m_ListBoxPages.DisplayMember = "Name";
            this.m_ListBoxPages.FormattingEnabled = true;
            this.m_ListBoxPages.Location = new System.Drawing.Point(18, 53);
            this.m_ListBoxPages.Name = "m_ListBoxPages";
            this.m_ListBoxPages.Size = new System.Drawing.Size(236, 290);
            this.m_ListBoxPages.TabIndex = 1;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // m_PanelPages
            // 
            this.m_PanelPages.Controls.Add(descriptionLabel);
            this.m_PanelPages.Controls.Add(this.descriptionTextBox);
            this.m_PanelPages.Controls.Add(this.imageNormalPictureBox);
            this.m_PanelPages.Controls.Add(likesCountLabel);
            this.m_PanelPages.Controls.Add(this.likesCountTextBox);
            this.m_PanelPages.Controls.Add(nameLabel);
            this.m_PanelPages.Controls.Add(this.nameTextBox);
            this.m_PanelPages.Controls.Add(talkingAboutCountLabel);
            this.m_PanelPages.Controls.Add(this.talkingAboutCountTextBox);
            this.m_PanelPages.Controls.Add(websiteLabel);
            this.m_PanelPages.Controls.Add(this.websiteTextBox);
            this.m_PanelPages.Location = new System.Drawing.Point(289, 10);
            this.m_PanelPages.Name = "m_PanelPages";
            this.m_PanelPages.Size = new System.Drawing.Size(306, 383);
            this.m_PanelPages.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "No Description."));
            this.descriptionTextBox.Location = new System.Drawing.Point(131, 143);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(151, 55);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(46, 22);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(195, 102);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(131, 270);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(151, 20);
            this.likesCountTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(131, 212);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 46);
            this.nameTextBox.TabIndex = 7;
            // 
            // talkingAboutCountTextBox
            // 
            this.talkingAboutCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "TalkingAboutCount", true));
            this.talkingAboutCountTextBox.Location = new System.Drawing.Point(131, 303);
            this.talkingAboutCountTextBox.Name = "talkingAboutCountTextBox";
            this.talkingAboutCountTextBox.Size = new System.Drawing.Size(151, 20);
            this.talkingAboutCountTextBox.TabIndex = 9;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(131, 333);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(151, 20);
            this.websiteTextBox.TabIndex = 11;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 501);
            this.Controls.Add(this.m_TabHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserInterface";
            this.Text = "Facebook App by Daniel & Amir";
            this.m_TabHome.ResumeLayout(false);
            this.m_TabPageLogin.ResumeLayout(false);
            this.m_TabPageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfile)).EndInit();
            this.m_TabLikeStatus.ResumeLayout(false);
            this.m_TabLikeStatus.PerformLayout();
            this.m_TabPagePostStatus.ResumeLayout(false);
            this.m_TabPagePostStatus.PerformLayout();
            this.m_TabPagePictureLikes.ResumeLayout(false);
            this.m_TabPagePictureLikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPictureLikes)).EndInit();
            this.m_TabEvent.ResumeLayout(false);
            this.m_TabEvent.PerformLayout();
            this.m_PanelEvents.ResumeLayout(false);
            this.m_PanelEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iEventAdapterBindingSource)).EndInit();
            this.m_TabPages.ResumeLayout(false);
            this.m_TabPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.m_PanelPages.ResumeLayout(false);
            this.m_PanelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl m_TabHome;
        private System.Windows.Forms.TabPage m_TabPageLogin;
        private System.Windows.Forms.TabPage m_TabPagePostStatus;
        private System.Windows.Forms.PictureBox m_PictureBoxProfile;
        private System.Windows.Forms.Button m_LogginButton;
        private System.Windows.Forms.Button m_ButtonPost;
        private System.Windows.Forms.TextBox m_TextBoxPost;
        private Label m_LabelLoggin;
        private TabPage m_TabPagePictureLikes;
        private Button m_ButtonPictureLikes;
        private Label m_LabelPictureLikes;
        private PictureBox m_PictureBoxPictureLikes;
        private TabPage m_TabEvent;
        private Button m_ButtonEvents;
        private ListBox m_ListBoxEvents;
        private Label m_LabelEvents;
        private ListBox m_ListBoxAlbums;
        private Label m_LabelAlbums;
        private Label m_LabelCreatedTime;
        private Label m_LabelCreatedTimeTopic;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private TabPage m_TabLikeStatus;
        private ListBox m_ListBoxStatuses;
        private Button m_ButtonGetStatus;
        private Button m_ButtonLikeSelectedStatus;
        private TabPage m_TabPages;
        private Panel m_PanelPages;
        private Button m_ButtonGetPages;
        private ListBox m_ListBoxPages;
        private TextBox descriptionTextBox;
        private BindingSource pageBindingSource;
        private PictureBox imageNormalPictureBox;
        private TextBox likesCountTextBox;
        private TextBox nameTextBox;
        private TextBox talkingAboutCountTextBox;
        private TextBox websiteTextBox;
        private Panel m_PanelEvents;
        private Label m_PagesLabel;
        private Button m_GoogleSearcher;
        private TextBox attendingUsersTextBox;
        private BindingSource iEventAdapterBindingSource;
        private TextBox descriptionTextBox1;
        private DateTimePicker endTimeDateTimePicker;
        private DateTimePicker startTimeDateTimePicker;
        private Label m_LabelShowBy;
        private ListBox m_ListBoxShowBy;
    }
}
