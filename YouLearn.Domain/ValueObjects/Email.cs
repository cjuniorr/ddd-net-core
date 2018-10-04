using System;
using System.Collections.Generic;
using System.Text;

namespace YouLearn.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;

            if (Address.IndexOf('@') < 1)
            {
                throw new Exception("Invalid email.");
            }
        }

        public string Address { get; set; }
    }
}
