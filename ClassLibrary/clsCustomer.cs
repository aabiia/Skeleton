using System;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;

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

        private Boolean mIsActive;
        //active public property
        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }



        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string firstName, string lastName, string email, string address, string dateOfBirth)
        { 
            string Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //firstname
            if (firstName.Length == 0)
            {
                Error = Error + "The First Name may not be blank : ";
            }
            if (firstName.Length > 50)
            {
                Error = Error + "First name should be less than 50 char : ";
            }
            //lastname
            if (lastName.Length == 0)
            {
                Error = Error + "The Last Name may not be blank : ";
            }
            if (lastName.Length > 50)
            {
                Error = Error + "Last name should be less than 50 char : ";
            }
            //email
            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (email.Length > 255)
            {
                Error = Error + "Last name should be less than 50 char : ";
            }
            //address
            if (address.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (address.Length > 255)
            {
                Error = Error + "Last name should be less than 50 char : ";
            }
            DateTime DateComp = DateTime.Now.Date;
            //dateofbirth
            try
            {
                //copy the dateofbirth value to the datetemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                //compare dateofbirth with date
                if (DateTemp > DateComp)
                {
                    Error = Error + "the date of birth is invalid";
                }
                //check if the date is greater than todays date
                if (DateTemp > DateComp)
                {
                    Error = Error + "the date of birth cannot be in the future : ";
                }
                return Error;
            }
            catch
            {
                Error = Error + "The date was not valid : ";

                return Error;
            }


        }

    }
}

