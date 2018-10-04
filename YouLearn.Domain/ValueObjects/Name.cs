using System;

namespace YouLearn.Domain.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


            if (FirstName.Length < 3 || FirstName.Length > 50)
            {
                throw new Exception("The first name is required and needs to contain between 3 and 50 characters.");
            }

            if (LastName.Length < 3 ||LastName.Length > 50)
            {
                throw new Exception("The last name is required and needs to contain between 3 and 50 characters.");
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
