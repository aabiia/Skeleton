using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }



        [TestMethod]
        public void ProuctListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 5;
            TestItem.PaymentMethod = "Card";
            TestItem.Address = "Birmingham, United Kindgdom";
            TestItem.PaymentStatus = true;
            TestItem.Date = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 someCount = 0;
            AllOrders.Count = someCount;
            Assert.AreEqual(AllOrders.Count, someCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 1;
            TestItem.CustomerID = 5;
            TestItem.PaymentMethod = "Card";
            TestItem.Address = "Birmingham, United Kindgdom";
            TestItem.PaymentStatus = true;
            TestItem.Date = DateTime.Now.Date;


            AllOrders.ThisOrder = TestItem;

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }




        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 1;
            TestItem.CustomerID = 5;
            TestItem.PaymentMethod = "Card";
            TestItem.Address = "Birmingham, United Kindgdom";
            TestItem.PaymentStatus = true;
            TestItem.Date = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }


        
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder OrderTesting = new clsOrder();
            Int32 PrimaryKey = 0;
            OrderTesting.CustomerID = 1009;
            OrderTesting.PaymentMethod = "Card";
            OrderTesting.Address = "Birmingham, United Kingdom, this.Earth";
            OrderTesting.PaymentStatus = false;
            OrderTesting.Date = DateTime.Now;
            AllOrders.ThisOrder = OrderTesting;
            PrimaryKey = AllOrders.Add();
            OrderTesting.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, OrderTesting);

        }




        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder OrderTesting = new clsOrder();
            Int32 PrimaryKey = 0;
            OrderTesting.CustomerID = 1009;
            OrderTesting.PaymentMethod = "Online Transection";
            OrderTesting.Address = "Birmingham, United Kingdom, this.Earth";
            OrderTesting.PaymentStatus = false;
            OrderTesting.Date = DateTime.Now;
            AllOrders.ThisOrder = OrderTesting;
            PrimaryKey = AllOrders.Add();
            OrderTesting.OrderID = PrimaryKey;
            OrderTesting.CustomerID = 2009;
            OrderTesting.PaymentMethod = "Paypal";
            OrderTesting.Address = "Leicester, United Kingdom, this.Earth";
            OrderTesting.PaymentStatus = true;
            OrderTesting.Date = DateTime.Now;
            AllOrders.ThisOrder = OrderTesting;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, OrderTesting);
        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder OrderTesting = new clsOrder();
            Int32 PrimaryKey = 0;
            OrderTesting.CustomerID = 2009;
            OrderTesting.PaymentMethod = "Paypal";
            OrderTesting.Address = "Leicester, United Kingdom, this.Earth";
            OrderTesting.PaymentStatus = true;
            OrderTesting.Date = DateTime.Now;
            AllOrders.ThisOrder = OrderTesting;
            PrimaryKey = AllOrders.Add();
            OrderTesting.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByAddress("lllodu");
            Assert.AreEqual(0, FilteredOrders.Count);

        }


        [TestMethod]

        public void ReportByOrderNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByAddress("Birmingham");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 25)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[0].OrderID != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }
    }
}
