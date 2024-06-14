using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }


        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.IsActive = true;
            TestItem.FirstName = "John";
            TestItem.LastName = "Stone";
            TestItem.Gender = "Male";
            TestItem.Position = "HR";
            TestItem.DateHired = DateTime.Now;
            TestItem.Address = "10 Blue Fox Close";
            TestItem.Email = "johnstones@gmail.com";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);

        }

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.IsActive = true;
            TestStaff.FirstName = "John";
            TestStaff.LastName = "Stone";
            TestStaff.Gender = "Male";
            TestStaff.Position = "HR";
            TestStaff.DateHired = DateTime.Now;
            TestStaff.Address = "10 Blue Fox Close";
            TestStaff.Email = "johnstones@gmail.com";

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.IsActive = true;
            TestItem.FirstName = "John";
            TestItem.LastName = "Stone";
            TestItem.Gender = "Male";
            TestItem.Position = "HR";
            TestItem.DateHired = DateTime.Now;
            TestItem.Address = "10 Blue Fox Close";
            TestItem.Email = "johnstones@gmail.com";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.IsActive = true;
            TestItem.FirstName = "John";
            TestItem.LastName = "Stone";
            TestItem.Gender = "Male";
            TestItem.Position = "HR";
            TestItem.DateHired = DateTime.Now;
            TestItem.Address = "10 Blue Fox Close";
            TestItem.Email = "johnstones@gmail.com";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    

    }


}
