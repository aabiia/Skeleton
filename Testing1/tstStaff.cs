using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        //declare data once so we dont have to duplicate the same data every time.
        string FirstName = "Ronaldo";
        string LastName = "Chris";
        string Gender = "Male";
        string Position = "Customer Service";
        string DateHired = DateTime.Now.ToShortDateString();
        string Address = "6 Mill Street";
        string Email = "ronaldojr@gmail.com";

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void IsActivePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean TestData = true;

            AnStaff.IsActive = TestData;

            Assert.AreEqual(AnStaff.IsActive, TestData);
        }
        [TestMethod]
        public void DateHiredPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateHired = TestData;
            Assert.AreEqual(AnStaff.DateHired, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "6 Mill Street";
            //assign the data to the property
            AnStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Address, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "johnstone@gmail.com";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            AnStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Stone";
            //assign the data to the property
            AnStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.LastName, TestData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            AnStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Gender, TestData);
        }
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "HR";
            //assign the data to the property
            AnStaff.Position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Position, TestData);
        }
        //Find method test 

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 8;
            Found = AnStaff.Find(StaffId);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 8;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffId != 8)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestDateHiredFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 8;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.DateHired != Convert.ToDateTime("10/10/2021"))
            {
                OK = false;
            }

            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the town property
            if (AnStaff.Email != "ronaldojr@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the town property
            if (AnStaff.FirstName != "Ronaldo")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the town property
            if (AnStaff.LastName != "Chris")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the post code property
            if (AnStaff.Address != "6 Mill Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the post code property
            if (AnStaff.Gender != "Male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TestPositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the date added property
            if (AnStaff.Position != "Customer Service")
            {
                OK = false;
            }



            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 8;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the active property
            if (AnStaff.IsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        //Tests - Mid, min, Max, Plusone, LessOne

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void FirstNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(100, 'a'); //should fail 
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; //this should be ok
                                   //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void LastNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(100, 'a'); //should fail 
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "a"; //this should be ok
                                 //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string Gender = "";
            Gender = Gender.PadRight(49, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Gender = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "";
            Gender = Gender.PadRight(50, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Gender = "";
            Gender = Gender.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void GenderExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Gender = "";
            Gender = Gender.PadRight(100, 'a'); //should fail 
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Gender = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Position = "a"; //this should be ok
                                   //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Position = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string Position = "";
            Position = Position.PadRight(49, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Position = "";
            Position = Position.PadRight(50, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "";
            Position = Position.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void PositionExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Position = "";
            Position = Position.PadRight(100, 'a'); //should fail 
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Position = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateHiredExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
      
        [TestMethod]
        public void DateHiredExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateHiredMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to 20 years ago
            TestDate = DateTime.Now.AddYears(-20);
            //change the date to 20 years ago minus 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateHiredMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to 20 years ago
            TestDate = DateTime.Now.AddYears(-20);
            //change the date to 20 years ago plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateHiredMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateHiredMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now;
            //change the date to today minus 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now;
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to 10 years ago
            TestDate = DateTime.Now.AddYears(-10);
            //convert the date variable to a string variable
            string DateHired = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string DateHired = "this is no a date!";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
                                   //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(50, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void AddressExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(100, 'a'); //should fail 
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
                                  //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string Email = "";
            Email = Email.PadRight(29, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(30, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void EmailExtremeMax()
        { 
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(100, 'a'); //should fail 
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Error = AnStaff.Valid(FirstName, LastName, Gender, Position, DateHired, Address, Email);
            Assert.AreNotEqual(Error, "");
        }


    }
 }


