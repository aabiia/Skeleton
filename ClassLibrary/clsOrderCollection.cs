using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();



        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set { mThisOrder = value;}
        }
        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@PaymentStatus", mThisOrder.PaymentStatus);
            DB.AddParameter("@Date", mThisOrder.Date);
            return DB.Execute("sproc_tblOrder_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@PaymentStatus", mThisOrder.PaymentStatus);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByAddress(string Address)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Address", Address);
            DB.Execute("sproc_tblOrder_FilterByAddress");
            PopulateArray(DB);
        }



        public clsOrderCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblorder_SelectAll");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.PaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentStatus"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}