using System;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq.Expressions;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;

        //addressId public property
        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }
        private DateTime mDateHired; //private data member
        public DateTime DateHired
        {
            get
            {
                return mDateHired;
            }
            set
            {
                mDateHired = value;
            }
        }

        private Boolean mIsActive;

        public bool IsActive
        {
            get
            {
                //this line of code sends data out of the property
                return mIsActive;
            }
            set
            {
                //this line of code allows data into the property
                mIsActive = value;
            }
        }

        private string mAddress;
        //street public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }


        private string mEmail;
        //street public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        private string mFirstName;
        //street public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }
        private string mLastName;
        //street public property
        public string LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }
        private string mGender;
        //street public property
        public string Gender
        {
            get
            {
                //this line of code sends data out of the property
                return mGender;
            }
            set
            {
                //this line of code allows data into the property
                mGender = value;
            }
        }
        private string mPosition;
        //street public property
        public string Position
        {
            get
            {
                //this line of code sends data out of the property
                return mPosition;
            }
            set
            {
                //this line of code allows data into the property
                mPosition = value;
            }
        }


        public bool Find(int staffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {

                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["AddressId"]);
                mDateHired = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string gender, string position, string dateHired, string address, string email)
        {
            //create a string variable to store the error
            String Error = "";
            //is the address field blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }

            //if the email is too long
            if (address.Length > 30)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the dateHired is blank
            if (dateHired.Length == 0)
            {
                //record the error
                Error = Error + "The date hired may not be blank : ";
            }
            else
            {
                try
                {
                    //copy the dateHired value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(dateHired);
                    DateTime DateComp = DateTime.Now.Date;
                    if (DateTemp < DateComp.AddYears(-20)) //check if date is older than 20 years
                    {
                        //record the error
                        Error = Error + "The date hired must be within 20 years : ";
                    }
                    if (DateTemp > DateComp) //compare dateHired with today's date
                    {
                        //record the error
                        Error = Error + "The date hired cannot be in the future : ";
                    }
                }
                catch
                {
                    //record the error
                    Error = Error + "The date hired is not a valid date : ";
                }
            }
            //is the email field blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email field may not be blank : ";
            }

            //if the email is too long
            if (email.Length > 30)
            {
                //record the error
                Error = Error + "The email must be less than 30 characters : ";
            }
            //is first name blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "First name may not be blank : ";
            }
            //if the street is too long
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "First name must be less than 50 characters : ";
            }

            //is last name blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "Last name may not be blank : ";
            }
            //if the street is too long
            if (lastName.Length > 50)
            {
                //record the error
                Error = Error + "Last name must be less than 50 characters : ";
            }
            //is the gender field blank
            if (gender.Length == 0)
            {
                //record the error
                Error = Error + "The gender field may not be blank : ";
            }
            //if the town is too long
            if (gender.Length > 50)
            {
                //record the error
                Error = Error + "The gender field must be less than 50 characters : ";
            }
            //is the position field blank
            if (position.Length == 0)
            {
                //record the error
                Error = Error + "The position field may not be blank : ";
            }
            //if the town is too long
            if (position.Length > 50)
            {
                //record the error
                Error = Error + "The position field must be less than 50 characters : ";
            }

            //return any error messages
            return Error;
        }
    }
}







