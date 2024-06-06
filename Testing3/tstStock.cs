using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        string Product_Name = "Sample Product";
        string Prod_Description = "This is a sample product description.";
        string Prod_Price = "10.99";
        string Prod_Quantity = "100";
        string Date_Added = DateTime.Now.Date.ToString();


        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            clsStock Product = new clsStock();
            Assert.IsNotNull(Product);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void Product_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Product.Product_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Product_ID, TestData);
        }

        [TestMethod]
        public void Product_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            string TestData = "Foaming Face Wash";
            //assign the data to the property
            Product.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Product_Name, TestData);
        }

        [TestMethod]
        public void Prod_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            string TestData = "Gentle foaming cleanser for all skin types";
            //assign the data to the property
            Product.Prod_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Prod_Description, TestData);
        }

        [TestMethod]
        public void Prod_PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            float TestData = 16.99f;
            //assign the data to the property
            Product.Prod_Price = (int)TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Prod_Price, (int)TestData);
        }

        [TestMethod]
        public void Prod_QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            int TestData = 150;
            //assign the data to the property
            Product.Prod_Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Prod_Quantity, TestData);
        }

        [TestMethod]
        public void Date_AddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Product.Date_Added = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Date_Added, TestData);
        }

        [TestMethod]
        public void Supplier_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            Product.Supplier_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Supplier_ID, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/


        [TestMethod]
        public void TestProduct_IDFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Product_ID property
            if (Product.Product_ID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProduct_NameFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Prod_Description
            if (Product.Product_Name != "Aloe Vera")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProd_DescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Prod_Description
            if (Product.Prod_Description != "Soothing gel for sunburns and sensitive skin")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProd_PriceFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Prod_Price
            if (Product.Prod_Price != 145)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProd_QuantityFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Prod_Quantity property
            if (Product.Prod_Quantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDate_AddedFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Date_Added property
            if (Product.Date_Added != Convert.ToDateTime("01-02-2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_IDFound()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 3;
            //invoke the method
            Found = Product.Find(Product_ID);
            //check the Supplier_ID property
            if (Product.Supplier_ID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /******************Valid METHOD TEST******************/



        [TestMethod]

        public void ValidMethodOK()
        {
            //Create an Instance of the class we want to test.
            clsStock Product = new clsStock();
            //String variable to store any error
            String Error = "";
            //Invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /**************Testing the Preoduct_Name**************/

        // Product_Name Tests

        [TestMethod]
        public void Product_NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product_Name = ""; //this should fail.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
    public void Product_NameMin()
        {
            clsStock Product = new clsStock();
            String Error = "";
            string Product_Name = "a"; // this should be okay
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_NameMinPlusOne()
        {
            clsStock Product = new clsStock();
            String Error = "";
            string Product_Name = "aa"; // this should be okay
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_NameMaxLessOne()
        {
            clsStock Product = new clsStock();
            String Error = "";
            string Product_Name = "";
            Product_Name = Product_Name.PadRight(49, 'a'); // this should be okay
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_NameMax()
        {
            clsStock Product = new clsStock();
            String Error = "";
            string Product_Name = "";
            Product_Name = Product_Name.PadRight(50, 'a'); // this should be okay
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_NameMaxPlusOne()
        {
            clsStock Product = new clsStock();
            String Error = "";
            string Product_Name = "";
            Product_Name = Product_Name.PadRight(51, 'a'); // this should fail
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Product_NameExtremeMax()
        {
            clsStock Product = new clsStock();
            String Error = "";
            string Product_Name = "";
            Product_Name = Product_Name.PadRight(500, 'a'); // this should fail
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            Assert.AreEqual(Error, "");
        }

        /**************Testing the Prod_Description**************/

        [TestMethod]
        public void Prod_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = ""; //this should fail.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = "a"; //this should pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = "aa"; //this should be pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = ""; //this should pass
            Prod_Description = Prod_Description.PadRight(999, 'a');
            //invoke the method.
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = ""; //this should pass.
            Prod_Description = Prod_Description.PadRight(1000, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = ""; //this should pass.
            Prod_Description = Prod_Description.PadRight(500, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = ""; //this should fail.
            Prod_Description = Prod_Description.PadRight(1001, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_DescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Description = ""; //this should fail.
            Prod_Description = Prod_Description.PadRight(5000, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /**************Testing the Prod_Price**************/



        [TestMethod]
        public void Prod_PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "-1"; //this should fail.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceMin()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "0"; //this should pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "1"; //this should be pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Prod_Price = "52"; //this should pass
            //invoke the method.
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceMax()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "53"; //this should pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceMid()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "26.5"; //this should pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "54"; //this should fail.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Price = "1000"; //this should fail.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        /**************Testing the Prod_Quantity**************/



        [TestMethod]
        public void Prod_QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = "-1"; //this should fail.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = "a"; //this should pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = "aa"; //this should be pass.
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = ""; //this should pass
            Prod_Quantity = Prod_Quantity.PadRight(49, 'a');
            //invoke the method.
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = ""; //this should pass.
            Prod_Quantity = Prod_Quantity.PadRight(50, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = ""; //this should pass.
            Prod_Quantity = Prod_Quantity.PadRight(25, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = ""; //this should fail.
            Prod_Quantity = Prod_Quantity.PadRight(51, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Prod_QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Prod_Quantity = ""; //this should fail.
            Prod_Quantity = Prod_Quantity.PadRight(500, 'a');
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        /*********************Date_Added***********************/

        [TestMethod]
        public void Date_AddedMin()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Date_AddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Date_AddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Date_AddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Product = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Date_AddedExtremeMax()
        {
            // Create an instance of the class we want to create
            clsStock Product = new clsStock();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to 100 years in the future
            TestDate = TestDate.AddYears(100);
            // Convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            // Invoke the method
            Error = Product.Valid(Product_Name, Prod_Description, Prod_Price, Prod_Quantity, Date_Added);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }



}