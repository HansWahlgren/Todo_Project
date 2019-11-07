using System;
using Xunit;
using Todo_Project.Model;

namespace XUnitTest_Todo_Project
{
    public class UnitTestPerson
    {
        [Fact]
        public void CreatePerson_ok()
        {
            //Arrange
            string firstName = "testfirstname";
            string lastName = "testlastname";

            //Act
            Person testPerson = new Person(firstName, lastName);

            //Assert
            Assert.Equal(firstName, testPerson.FirstName);
            Assert.Equal(lastName, testPerson.LastName);

        }

        [Fact]
        public void CreatePerson_not_letter()
        {
            //Arrange
            string firstName = "testname";
            string lastName = "7";
            string excpected_error_msg = "Name can only contain letters.";
            string error_msg = "";
            Person testPerson = null;

            //Act
            try
            {
            testPerson = new Person(firstName, lastName);
            }

            catch (ArgumentException exception)
            {
                error_msg = exception.Message;
            }

            //Assert
            Assert.Equal(excpected_error_msg, error_msg);           
        }

        [Fact]
        public void CreatePerson_not_null()
        {
            //Arrange
            string firstName = "testname";
            string lastName = "";
            string excepted_error_msg = "Name is too long or short.";
            string error_msg = "";
            Person testPerson = null;

            //Act
            try
            {
                testPerson = new Person(firstName, lastName);
            }

            catch (ArgumentException exception)
            {
                error_msg = exception.Message;
            }

            //Assert
            Assert.Equal(excepted_error_msg, error_msg);
        }
    }
}
