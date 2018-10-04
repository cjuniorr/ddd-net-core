using prmToolkit.NotificationPattern;
using System;
using YouLearn.Domain.Arguments.User;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Repositories;
using YouLearn.Domain.Interfaces.Services;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Services
{
    public class ServiceUser : Notifiable, IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public AddUserResponse AddUser(AddUserRequest request)
        {
            if (request == null)
            {
                AddNotification("AddUserRequest", "AddUserRequest object is required");
                return null;
            }

            Name name = new Name(request.FirstName, request.LastName);
            Email email = new Email(request.Email);

            User user = new User(name, email, request.Password);

            if (this.IsInvalid()) return null;

            _repositoryUser.Save(user);

            return new AddUserResponse(user.Id);
        }

        public UserAuthenticateResponse UserAuthenticate(UserAuthenticateRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
