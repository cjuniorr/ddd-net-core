﻿using System;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class Video : EntityBase
    {
        public Channel Channel { get; set; }
        public  Playlist Playlist { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int PlaylistOrder { get; set; }
        public string IdVideoYoutube { get; set; }
        public User UserSuggested { get; set; }
        public EnumStatus Status { get; set; }
    }
}
