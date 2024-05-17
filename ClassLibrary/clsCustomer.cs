using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
      
     
        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
             }
            set
            {
                mCustomerId = value;
            }
        }

        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }


        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int CustomerId)
        {
            mCustomerId = 1;
            mFirstName = "Lucy";
            mLastName = "Oak";
            mEmail = "loak.1@gmail.com";
            mAddress = "cannon street, LE7 YST";
            mDateOfBirth = Convert.ToDateTime ("18/05/2000");
            mActive = true;
            return true; 
        }

       

    }
    }

