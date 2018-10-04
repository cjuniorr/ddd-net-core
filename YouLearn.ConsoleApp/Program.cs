using System;
using YouLearn.Domain.Arguments.User;
using YouLearn.Domain.Services;

namespace YouLearn.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddUserRequest request = new AddUserRequest
            {
                Email = "celiopaivajr@gmail.com",
                FirstName = "Celio",
                LastName = "Teixeira Paiva",
                Password = "123aewqeetre"
            };

            var response = new ServiceUser().AddUser(request);
            Console.ReadKey();
        }
    }
}
