using System;

namespace YouLearn.Domain.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Status { get; set; }
    }
}
