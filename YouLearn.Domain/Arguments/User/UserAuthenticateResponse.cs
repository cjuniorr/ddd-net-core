using System;
using System.Collections.Generic;
using System.Text;

namespace YouLearn.Domain.Arguments.User
{
    public class UserAuthenticateResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
    }
}
