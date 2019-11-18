using System;
using Xunit;
using Todo_Project.Model;

namespace XUnitTest_Todo_Project
{
    public class UnitTestTodo
    {
        [Fact]
        public void CreateTodo_ok()
        {
            //Arrange
            string description = "Go out with the dog";

            //Act
            Todo testTodo = new Todo(description);

            //Assert
            Assert.Equal(description, testTodo.Description);
        }

        [Fact]
        public void CreateTodo_not_null()
        {
            //Arrange
            string description = "";
            string expected_error_msg = "Description is too long or short.";
            string error_msg = "";

            //Act
            try
            {
                Todo testTodo = new Todo(description);
            }

            catch (ArgumentException exception)
            {
                error_msg = exception.Message;
            }

            //Assert
            Assert.Equal(expected_error_msg, error_msg);
        }
    }
}
