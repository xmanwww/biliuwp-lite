﻿using System.Collections.ObjectModel;
using BiliLite.Models.Common.Video;
using BiliLite.ViewModels.Common;
using PropertyChanged;

namespace BiliLite.ViewModels.Video
{
    public class VideoListSectionViewModel : BaseViewModel
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public bool Selected { get; set; }

        public ObservableCollection<VideoListItem> Items { get; set; }

        public VideoListItem SelectedItem { get; set; }

        public bool IsLazyOnlineList { get; set; }

        [DoNotNotify]
        public string OnlineListId { get; set; }
    }
}