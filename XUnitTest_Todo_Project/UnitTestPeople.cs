using System;
using Xunit;
using Todo_Project.Data;
using Todo_Project.Model;


namespace XUnitTest_Todo_Project
{
    public class UnitTestPeople
    {
        [Fact]
        public void CheckSize_Ok()
        {
            //Arrange
            Person person1 = People.AddNewPerson("Philip", "Wahlgren");
            Person person2 = People.AddNewPerson("Mikael", "Aurell");
            Person person3 = People.AddNewPerson("Mike", "Johnsson");

            //Act
            int arraySize = People.Size();

            //Assert
            Assert.Equal(3, arraySize);
        }

        [Fact]
        public void CheckFindAll_Ok()
        {
            //Arrange
            Person person1 = People.AddNewPerson("Robert", "Berr");
            Person person2 = People.AddNewPerson("Elin", "Fox");
            Person person3 = People.AddNewPerson("Karin", "Bengtsson");

            //Act
            Person[] allArray = People.FindAll();

            //Assert
            Assert.Equal(person1.LastName, allArray[0].LastName);
            Assert.Equal(person2.PersonId, allArray[1].PersonId);
            Assert.Equal(person3.FirstName, allArray[2].FirstName);
        }

        [Fact]
        public void CheckFindById_Ok()
        {
            //Arrange
            Person person1 = People.AddNewPerson("Tjell", "Andersson");
            Person person2 = People.AddNewPerson("Tina", "Bengtsson");
            Person person3 = People.AddNewPerson("Linn", "Trump");

            //Act
            Person chosenOne = People.FindById(person2.PersonId);

            //Assert
            Assert.Equal(person2.PersonId, chosenOne.PersonId);
        }

        [Fact]
        public void CheckCreateNewPerson_Ok()
        {
            //Arrange
            People.AddNewPerson("Malin", "Persson");
            People.AddNewPerson("Ola", "Brönesson");
            People.AddNewPerson("Erika", "Fragerhult");

            //Act
            Person chosenOne = People.AddNewPerson("Ulf", "Correctsson");
            Person[] allArray = People.FindAll();

            //Assert
            Assert.Equal(allArray[allArray.Length-1].PersonId, chosenOne.PersonId);
        }

        [Fact]
        public void CheckPeopleClear_Ok()
        {
            //Arrange
            People.AddNewPerson("Ida", "Åkesson");
            People.AddNewPerson("Bernt", "Brynolfsson");
            People.AddNewPerson("Yvelena", "Bartholddotter");

            //Act
            People.Clear();
            Person[] allArray = People.FindAll();

            //Assert
            Assert.Empty(allArray);
        }
        [Fact]
        public void CheckRemovePerson_Ok()
        {
            //Arrange
            People.AddNewPerson("Gustav","Jönsson");
            People.AddNewPerson("Erik", "Philipsson");
            People.AddNewPerson("Jocke", "Hjarmsson");
            People.AddNewPerson("Edvin", "Andersson");
            Person[] personFullArray = People.FindAll();

            //Act
            People.RemovePerson(1);
            People.RemovePerson(3);
            Person[] nonRemovedPeopleArray = People.FindAll();

            //Assert
            Assert.Equal(personFullArray[1].PersonId, nonRemovedPeopleArray[0].PersonId);
            Assert.Equal("Erik", nonRemovedPeopleArray[0].FirstName);
            Assert.Equal(personFullArray[3].PersonId, nonRemovedPeopleArray[1].PersonId);
            Assert.Equal("Edvin", nonRemovedPeopleArray[1].FirstName);
        }
    }
}
