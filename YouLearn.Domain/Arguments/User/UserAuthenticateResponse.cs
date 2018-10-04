using System;
using System.Collections.Generic;
using System.Text;
using YouLearn.Domain.Entities;

namespace YouLearn.Domain.Arguments.User
{
    public class UserAuthenticateResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public static explicit operator UserAuthenticateResponse(Entities.User entity)
        {
            return new UserAuthenticateResponse()
            {
                Id = entity.Id,
                FirstName = entity.Name.FirstName
            };
        }
    }
}
