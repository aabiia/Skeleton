using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Assert.IsNotNull(AnUser);
        }
        
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Int32 TestData = 6;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "";
            AnUser.Username = TestData;
            Assert.AreEqual(AnUser.Username, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FindUserMethodOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            string Username = "Ali Ahmed";
            string Password = "Ali111";
            Found = AnUser.FindUser(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestReviewnamePWFound()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            Boolean Ok = true;
            string Username = "Ali Ahmed";
            string Password = "Ali111";
            Found = AnUser.FindUser(Username, Password);

            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
