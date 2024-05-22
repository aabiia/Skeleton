using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            clsCustomer TestItem = new clsCustomer();
            TestItem.IsActive = true;
            TestItem.CustomerId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FirstName = "Lucy";
            TestItem.LastName = "Oak";
            TestItem.Email = "loak.1@gmail.com";
            TestItem.Address = "cannon street";

            List<clsCustomer> TestList = new List<clsCustomer>();
            TestList.Add(TestItem);
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

       

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.IsActive = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.DateOfBirth = DateTime.Now;
            TestCustomer.FirstName = "Lucy";
            TestCustomer.LastName = "Oak";
            TestCustomer.Email = "loak.1@gmail.com";
            TestCustomer.Address = "cannon street";
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.IsActive = true;
            TestItem.CustomerId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FirstName = "Lucy";
            TestItem.LastName = "Oak";
            TestItem.Email = "loak.1@gmail.com";
            TestItem.Address = "cannon street";

            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.IsActive = true;
            TestItem.CustomerId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FirstName = "Lucy";
            TestItem.LastName = "Oak";
            TestItem.Email = "loak.1@gmail.com";
            TestItem.Address = "cannon street";
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

    }
}
