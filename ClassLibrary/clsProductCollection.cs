using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary
{
    public class clsProductCollection

    {


        List<clsStock> mProductList = new List<clsStock>();

        clsStock mThisProduct = new clsStock();


        public List<clsStock> ProductList
        {
            get
            {
                return mProductList;
            }

            set
            {
                mProductList = value;
            }

        }

        public int Count
        {
            get
            {
                return mProductList.Count;
            }

            set
            {


            }
        }

        public clsStock ThisProduct
        {
            get
            {
                return mThisProduct;
            }

            set
            {
                mThisProduct = value;
            }
        }

        public clsProductCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProduct_SelectAll");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount ;
            RecordCount = DB.Count;
            mProductList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock AProduct = new clsStock();

                AProduct.Product_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_ID"]);
                AProduct.Product_Name = Convert.ToString(DB.DataTable.Rows[Index]["Product_Name"]);
                AProduct.Prod_Description = Convert.ToString(DB.DataTable.Rows[Index]["Prod_Description"]);
                AProduct.Prod_Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Prod_Price"]);
                AProduct.Prod_Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Prod_Quantity"]);
                AProduct.Supplier_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Supplier_ID"]);
                AProduct.Date_Added = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date_Added"]);

                mProductList.Add(AProduct);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Product_Name", mThisProduct.Product_Name);
            DB.AddParameter("@Prod_Description", mThisProduct.Prod_Description);
            DB.AddParameter("@Prod_Price", mThisProduct.Prod_Price);
            DB.AddParameter("@Prod_Quantity", mThisProduct.Prod_Quantity);
            DB.AddParameter("@Date_Added", mThisProduct.Date_Added);
            DB.AddParameter("@Supplier_ID", mThisProduct.Supplier_ID);
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Update()
        {
            
           clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Product_ID", mThisProduct.Product_ID);
            DB.AddParameter("@Product_Name", mThisProduct.Product_Name);
            DB.AddParameter("@Prod_Description", mThisProduct.Prod_Description);
            DB.AddParameter("@Prod_Price", mThisProduct.Prod_Price);
            DB.AddParameter("@Prod_Quantity", mThisProduct.Prod_Quantity);
            DB.AddParameter("@Date_Added", mThisProduct.Date_Added);
            DB.AddParameter("@Supplier_ID", mThisProduct.Supplier_ID);
            DB.Execute("sproc_tblProduct_Update");
        }

        public void Delete()
        {
            clsDataConnection DB2 = new clsDataConnection();

            DB2.AddParameter("@Product_ID", mThisProduct.Product_ID);
            DB2.Execute("sproc_tblProduct_Delete");
        }

        public void ReportByProductName(string Product_Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Product_Name", Product_Name);
            DB.Execute("sproc_tblProduct_FilterByProduct_Name");
            PopulateArray(DB);
        }
    }


}
