using System;
using YouLearn.Domain.Entities.Base;

namespace YouLearn.Domain.Entities
{
    public class Channel : EntityBase
    {
        public string Name { get; set; }
        public string UrlLogo { get; set; }
        public User User { get; set; }
    }
}
