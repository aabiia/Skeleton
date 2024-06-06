using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 5;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }



        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "PaymentMethod for the Order.";
            AnOrder.PaymentMethod = TestData;
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }



        [TestMethod]
        public void AddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Birmingham, United Kingdom, Earth.";
            AnOrder.Address = TestData;
            Assert.AreEqual(AnOrder.Address, TestData);
        }


        [TestMethod]
        public void DatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.Date = TestData;
            Assert.AreEqual(AnOrder.Date, TestData);
        }

        [TestMethod]
        public void PaymentStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.PaymentStatus = TestData;
            Assert.AreEqual(AnOrder.PaymentStatus, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {

            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 5;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void tstCustomerIDDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerID != 103)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPaymentMethodFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.PaymentMethod != "Cash")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Address != "789 Oak St")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Date != Convert.ToDateTime("03-01-2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPaymentStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.PaymentStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        String CustomerID = "102";
        String PaymentMethod = "Card";
        String Address = "Burmingham, United Kingdom";
        String Date = Convert.ToString(DateTime.Now.Date);
        String PaymentStatus = Convert.ToString(true);

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 tstCustomerIDDate = -5;
            String CustomerID = tstCustomerIDDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 tstCustomerIDDate = 0;
            String CustomerID = tstCustomerIDDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 tstCustomerIDDate = 1;
            String CustomerID = tstCustomerIDDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 tstCustomerIDDate = 2;
            String CustomerID = tstCustomerIDDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";

            String CustomerID = "sd6cv1x2";
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String PaymentMethod = "";
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String PaymentMethod = "p";
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String PaymentMethod = "pp";
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(49, 'p');
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(50, 'p');
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(51, 'p');
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(25, 'p');
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(500, 'p');
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Address = "";
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Address = "a";
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Address = "aa";
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(249, 'a');
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(250, 'a');
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(251, 'a');
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(125, 'a');
                Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(5000, 'd');
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateExtremeMinimum()
        {
           clsOrder AnOrder = new clsOrder();
           String Error = "";
           DateTime TestDate = DateTime.Now.Date;
           TestDate = TestDate.AddYears(-100);
           string Date = TestDate.ToString();
           Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
           Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
             Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateExtremeMaximum()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Date = "This is not a Valid Date Data Type.";
            Error = AnOrder.Valid(CustomerID, PaymentMethod, Address, Date, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }


    }
}
