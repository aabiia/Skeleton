using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderID;
        private Int32 mCustomerID;
        private string mPaymentMethod;
        private string mAddress;
        private DateTime mDate;
        private Boolean mPaymentStatus;


        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }

        }

        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return mPaymentMethod;
            }
            set
            {
                mPaymentMethod = value;
            }
        }

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

        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }
        public bool PaymentStatus
        {
            get
            {
                return mPaymentStatus;
            }
            set
            {
                mPaymentStatus = value;
            }
        }

        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", orderID);
            DB.Execute("sproc_tblOrder_FilterbyOrderID");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentStatus"]);
                return true;

            }

            else
            {
                return false;
            }
        }

        public string Valid(string customerID, string paymentMethod, string address, string date, string paymentStatus)
        {
            string Error = "";
            Int32 tstCutomerID;
            DateTime tstDate;


            try
            {
                tstCutomerID = Convert.ToInt32(customerID);
                if(tstCutomerID <= 0)
                {
                    Error += "Customer Id must not be Negative and zero.";
                }
            }
            catch
            {
                Error += "Customer Id must be an Integer only.";
            }

            if (paymentMethod.Length == 0)
            {
                Error += "Payment Method must not be Empty.";
            }
            if (paymentMethod.Length > 50)
            {
                Error += "Payment Method must not be more than 50 Characters.";
            }

            if (address.Length == 0)
            {
                Error += "Address must not be Empty.";
            }
            if (address.Length > 250)
            {
                Error += "Address must not be more than 250 Characters.";
            }


            try
            {
                tstDate = Convert.ToDateTime(date);
                if (tstDate < DateTime.Now.Date)
                {
                    Error += "date must not be in the past.";
                }
                if (tstDate > DateTime.Now.Date)
                {
                    Error += "date must not be in the Future.";
                }
            }
            catch
            {
                Error += "Entered Date is not valid.";
            }


            return Error; 
        }
    }
}