using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
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
            //check the Product_Name property
            if (Product.Product_Name != "Test Name")
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
            if (Product.Prod_Description != "Test Description")
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
            if (Product.Prod_Price != 10)
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
            if (Product.Prod_Quantity != 12)
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
            if (Product.Date_Added != Convert.ToDateTime("23/12/2022"))
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
            if (Product.Supplier_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}
