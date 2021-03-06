﻿using System;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class Playlist : EntityBase
    {
        public string Name { get; private set; }
        public User User { get; private set; }
        public EnumStatus Status { get; private set; }
    }
}
