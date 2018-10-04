using prmToolkit.NotificationPattern;
using System;
using YouLearn.Domain.Arguments.User;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Services;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Services
{
    public class ServiceUser : Notifiable, IServiceUser
    {
        public AddUserResponse AddUser(AddUserRequest request)
        {
            if (request == null)
            {
                AddNotification("AddUserRequest", "AddUserRequest object is required");
                return null;
            }

            Name name = new Name(request.FirstName, request.LastName);
            Email email = new Email(request.Email);

            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Password = request.Password;


            if (user.Password.Length <= 3 )
            {
                throw new Exception("The password needs to contain at least 3 characters.");
            }

            //AddUserResponse response = new RepositoryUser().Save(user);
            //return response;
            return new AddUserResponse(Guid.NewGuid());
        }

        public UserAuthenticateResponse UserAuthenticate(UserAuthenticateRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
