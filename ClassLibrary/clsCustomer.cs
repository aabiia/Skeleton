using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int CustomerId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public bool Find(int CustomerId)
        {
            return true;
        }
    }

}