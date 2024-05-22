using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.NetworkInformation;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string FirstName = "Katie";
        string LastName = "Paul";
        string Email = "paulkatie98@gmail.com";
        string Address = "high road, NG7";
        string DateOfBirth = DateTime.Now.ToShortDateString(); 


        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void AcivePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.IsActive = TestData;
            Assert.AreEqual(AnCustomer.IsActive, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Lucy";
            AnCustomer.FirstName = TestData;
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Oak";
            AnCustomer.LastName = TestData;
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }


        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "loak.1@gmail.com";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "cannon street,LE7 YST";
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }


        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.DateOfBirth = TestData;
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 1;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerId != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.FirstName != "Anna")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.LastName != "Harvey")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Email != "annaharvey@yahoo.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Address != "eastern avenue, M25 PTR  ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.IsActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("03/10/1989"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

      
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address,DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(49,'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "a";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        //email
        [TestMethod]
        public void EmailExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(5, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(6, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(7, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(254, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(255, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(128, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(256, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        //address
        [TestMethod]
        public void AddressExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(5, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(6, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Email.PadRight(7, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(254, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(255, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(128, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(256, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        //dateofbirth
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whtever the date is -150 years
            TestDate = TestDate.AddYears(-150);
            //convert the date to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whtever the date is -1
            TestDate = TestDate.AddYears(-1);
            //convert the date to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whtever the date is +150
            TestDate = TestDate.AddYears(150);
            //convert the date to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string DateOfBirth = "this is not a date!";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Address, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
    }
}

