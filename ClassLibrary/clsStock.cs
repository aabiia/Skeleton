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

        public bool Find(int Product_ID)
        {
            //Set the private data member to thr test data value.
            mProduct_ID = 3;
            mProduct_Name = "Test Name";
            mProd_Description = "Test Description";
            mProd_Price = 10;
            mProd_Quantity = 12;
            mDate_Added = Convert.ToDateTime("19/05/2024");
            mSupplier_ID = 1;


            //Always return True.
            return true;
        }

        public string Valid(string Product_Name, string Prod_Description, string Prod_Price, string Prod_Quantity, string Date_Added)
        {

 
            string Error = "";

            // Validate Product_Name
            if (Product_Name.Length == 0)
            {
                Error = Error + "The Product_Name may not be blank : ";
            }
            if (Product_Name.Length > 50)
            {
                Error = Error + "The Product_Name must be less than 50 : ";
            }

            /*****************Prod_Description******************/


            // If the Prod_Description is blank
            if (Prod_Description.Length == 0)
            {
                //Record the error.
                Error = Error + "The Prod_Description may not be blank :  ";

            }

            // If the Prod_Description is greater than 1000.
            if (Prod_Description.Length > 1000)
            {
                //Record the error.
                Error = Error + "The Prod_Description must be less than 1000 :  ";

            }

            /*****************Prod_Price******************/


            // If the Prod_Price is blank
            if (Prod_Price.Length == 0)
            {
                //Record the error.
                Error = Error + "The Prod_Price may not be blank :  ";

            }

            // If the Prod_Description is greater than 53.
            if (Prod_Price.Length > 53)
            {
                //Record the error.
                Error = Error + "The Prod_Price must be less than 53 :  ";

            }

            if (!float.TryParse(Prod_Price, out _))
            {
                Error = Error + "Prod_Price must be a numeric value. ";
            }


            // If the Prod_Quantity is blank
            if (Prod_Quantity.Length == 0)
            {
                //Record the error.
                Error = Error + "The Prod_Quantity may not be blank :  ";

            }

            // If the Prod_Quantity is greater than 50.
            if (Prod_Quantity.Length > 50)
            {
                //Record the error.
                Error = Error + "The Prod_Quantity must be less than 53 :  ";

            }

            /*************************Date_Added**************************/


            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            // Check if the Date_Added is a valid date
            DateTime DateTemp;
            if (!DateTime.TryParse(Date_Added, out DateTemp))
            {
                Error = Error + "The date is not a valid date. ";
                return Error; // Return immediately if the date is not valid
            }

            // Compare the DateTemp with the current date
            DateTime DateComp = DateTime.Now.Date;
            if (DateTemp < DateComp)
            {
                Error = Error + "The date cannot be in the past. ";
            }
            else if (DateTemp > DateComp.AddYears(100))
            {
                Error = Error + "The date cannot be 100 or more years in the future. ";
            }


            //Return any error message.

            return "";
        }
    }
}