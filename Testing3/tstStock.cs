using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock Product = new clsStock();
             Assert.IsNotNull(Product);
        }


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
            Product.Prod_Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Prod_Price, TestData);
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
    }
}
