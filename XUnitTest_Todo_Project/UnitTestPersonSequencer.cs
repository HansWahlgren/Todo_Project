using System;
using Xunit;
using Todo_Project.Data;

namespace XUnitTest_Todo_Project
{
    public class UnitTestPersonSequencer
    {
        [Fact]
        public void Reset_to_zero()
        {
            //Arrange
            int personId = 15;

            //Act
            PersonSequencer.Reset();
            personId=PersonSequencer.NextPersonId();

            //Assert
            Assert.Equal(1, personId);
        }
    }
}
