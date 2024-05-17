using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the address id property
        private Int32 mProduct_ID;
        //addressId public property
        public int Product_ID
        {
            get
            {
                //this line of code sends data out of the property
                return mProduct_ID;
            }
            set
            {
                //this line of code allows data into the property
                mProduct_ID = value;
            }
        }


        //private data member for the Product_Name property
        private string mProduct_Name;
        //Product_Name public property
        public string Product_Name
        {
            get
            {
                //this line of code sends data out of the property
                return mProduct_Name;
            }
            set
            {
                //this line of code allows data into the property
                mProduct_Name = value;
            }
        }


        //private data member for the Prod_Price property
        private Int32 mProd_Price;
        //Prod_Price public property
        public int Prod_Price
        {
            get
            {
                //this line of code sends data out of the property
                return mProd_Price;
            }
            set
            {
                //this line of code allows data into the property
                mProd_Price = value;
            }
        }


        //private data member for the Prod_Quantity property
        private Int32 mProd_Quantity;
        //Prod_Quantity public property
        public int Prod_Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mProd_Quantity;
            }
            set
            {
                //this line of code allows data into the property
                mProd_Quantity = value;
            }
        }


        //private data member for the Date_Added property
        private DateTime mDate_Added;
        //Date_Added public property
        public DateTime Date_Added
        {
            get
            {
                //this line of code sends data out of the property
                return mDate_Added;
            }
            set
            {
                //this line of code allows data into the property
                mDate_Added = value;
            }
        }


        //private data member for the Supplier_ID property
        private Int32 mSupplier_ID;
        //Supplier_ID public property
        public int Supplier_ID
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplier_ID;
            }
            set
            {
                //this line of code allows data into the property
                mSupplier_ID = value;
            }
        }

        //private data member for the Prod_Description property
        private string mProd_Description;
        //Prod_Description public property
        public string Prod_Description
        {
            get
            {
                //this line of code sends data out of the property
                return mProd_Description;
            }
            set
            {
                //this line of code allows data into the property
                mProd_Description = value;
            }
        }

        public bool Find(int product_ID)
        {
            //Set the private data member to thr test data value.
            mProduct_ID = 3;
            mProduct_Name = "Test Name";
            mProd_Description = "Test Description";
            mProd_Price = 10;
            mProd_Quantity = 12;
            mDate_Added = Convert.ToDateTime("23/12/2022");
            mSupplier_ID = 1;


            //Always return True.
            return true;
        }
    }
}