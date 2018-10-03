using System;

namespace YouLearn.Domain.Entities
{
    public class Channel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlLogo { get; set; }
        public string User { get; set; }
    }
}
