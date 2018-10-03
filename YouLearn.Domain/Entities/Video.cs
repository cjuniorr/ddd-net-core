﻿using System;

namespace YouLearn.Domain.Entities
{
    public class Video
    {
        public Guid Id { get; set; }
        public Channel Channel { get; set; }
        public  Playlist Playlist { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int PlaylistOrder { get; set; }
        public string IdVideoYoutube { get; set; }
        public User UserSuggested { get; set; }
        public string Status { get; set; }
    }
}
