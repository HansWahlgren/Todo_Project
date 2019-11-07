using System;
using Xunit;
using Todo_Project.Data;

namespace XUnitTest_Todo_Project
{
    public class UnitTestTodoSequencer
    {
        [Fact]
        public void Reset_to_zero()
        {
            //Arrange
            int todoId = 15;

            //Act
            TodoSequencer.Reset();
            todoId = TodoSequencer.NextTodoId();

            //Assert
            Assert.Equal(1, todoId);
        }
    }
}
