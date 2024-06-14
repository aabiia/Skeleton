using System;
using System.Collections.Generic;
using System.Net;
namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();   
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;

            }

            set
            {
                mStaffList = value;

            }
        }
        public int Count

        {
            get
            { return mStaffList.Count; }

            set
            { //we shall worry about this later}

            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            //DB.AddParemeter("@FirstName" mThisStaff.FirstName);
            //DB.AddParemeter("@LastName" mThisStaff.FirstName);
            //DB.AddParemeter("@Gender" mThisStaff.Gender);
           // DB.AddParemeter("@Position" mThisStaff.Position);
            //DB.AddParemeter("@DateHired" mThisStaff.DateHired);
            //DB.AddParemeter("@Address" mThisStaff.Address);
            //DB.AddParemeter("@Email" mThisStaff.Email);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }

            set
            {
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]); ;
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AnStaff.DateHired = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateHired"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                //AnStaff.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mStaffList.Add(AnStaff);
                Index++;
            }   


           
        }
    }           

}
