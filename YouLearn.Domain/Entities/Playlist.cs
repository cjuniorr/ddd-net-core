using System;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class Playlist : EntityBase
    {
        public User User { get; set; }
        public EnumStatus Status { get; set; }
    }
}
