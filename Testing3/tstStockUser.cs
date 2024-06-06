using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Assert.IsNotNull(AnUser);
        }


        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Int32 TestData = 3;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "";
            AnUser.Username = TestData;
            Assert.AreEqual(AnUser.Username, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "8521452zxscdvgfth";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "Stock(Products) Department";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FindUserMethodOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Boolean Found = false;
            string Username = "Ahsan";
            string Password = "12345";
            Found = AnUser.FindUser(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestReviewnamePWFound()
        {
            clsStockUser AnUser = new clsStockUser();
            Boolean Found = false;
            Boolean Ok = true;
            string Username = "Ahsan";
            string Password = "12345";
            Found = AnUser.FindUser(Username, Password);

            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
