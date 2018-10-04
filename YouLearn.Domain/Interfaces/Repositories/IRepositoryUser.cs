using System;
using YouLearn.Domain.Entities;

namespace YouLearn.Domain.Interfaces.Repositories
{
    public interface IRepositoryUser
    {
        User Get(Guid id);
        User Get(string email, string password);

        void Save(User user);
        bool Found(string email);
    }
}
