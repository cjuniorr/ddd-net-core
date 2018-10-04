using System;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Extensions;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Entities
{
    public class User : EntityBase
    {
        public User(Email email, string password)
        {
            Email = email;
            Password = password;
        }

        public User(Name name, Email email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            if (Password.Length <= 3)
            {
                throw new Exception("The password needs to contain at least 3 characters.");
            }

            Password = Password.ConvertToMD5();
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
    }
}
