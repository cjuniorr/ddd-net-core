using System;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Entities
{
    public class User : EntityBase
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
    }
}
