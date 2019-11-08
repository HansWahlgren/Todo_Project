using System;
using Xunit;
using Todo_Project.Data;
using Todo_Project.Model;

namespace XUnitTest_Todo_Project
{
    public class UnitTestTodoItems
    {
        [Fact]
        public void CheckSize_Ok()
        {
            //Arrange
            TodoItems.AddNewTodo("Go out with the dog");
            TodoItems.AddNewTodo("Go out with the cat");
            TodoItems.AddNewTodo("Go out with the bird");

            //Act
            int arraySize = TodoItems.Size();

            //Assert
            Assert.Equal(3, arraySize);
        }

        [Fact]
        public void CheckFindAll_Ok()
        {
            //Arrange
            Todo todo1 = TodoItems.AddNewTodo("Robert Berr");
            Todo todo2 = TodoItems.AddNewTodo("Find the Fox");

            //Act
            Todo[] allArray = TodoItems.FindAll();

            //Assert
            Assert.Equal(todo1.Description, allArray[0].Description);
            Assert.Equal(todo2.TodoId, allArray[1].TodoId);
        }

        [Fact]
        public void CheckFindById_Ok()
        {
            //Arrange
            Todo todo1 = TodoItems.AddNewTodo("Drink a beer");
            Todo todo2 = TodoItems.AddNewTodo("Find the Bear");

            //Act
            Todo chosenOne = TodoItems.FindById(todo2.TodoId);

            //Assert
            Assert.Equal(todo2.TodoId, chosenOne.TodoId);
        }

        [Fact]
        public void CheckCreateNewTodo_Ok()
        {
            //Arrange
            Todo todo1 = TodoItems.AddNewTodo("Eat a burger");
            Todo todo2 = TodoItems.AddNewTodo("Buy another beer");
            Todo todo3 = TodoItems.AddNewTodo("Get a coffee");
            Todo todo4 = TodoItems.AddNewTodo("Send dad a bottle");

            //Act
            Todo chosenOne = TodoItems.AddNewTodo("Send dad a bottle");
            Todo[] allArray = TodoItems.FindAll();

            //Assert
            Assert.Equal(allArray[allArray.Length - 1].TodoId, chosenOne.TodoId);
        }

        [Fact]
        public void CheckTodoClear_Ok()
        {
            //Arrange
            TodoItems.AddNewTodo("Do this first");
            TodoItems.AddNewTodo("Then you have to do this");
            TodoItems.AddNewTodo("Finaly do this");

            //Act
            TodoItems.Clear();
            Todo[] allArray = TodoItems.FindAll();

            //Assert
            Assert.Empty(allArray);
        }
        /* UNIT TESTIN PART 2*/

        [Fact]
        public void FindByDoneStatus_Ok()
        {
            //Arrange
            Todo todo1 = TodoItems.AddNewTodo("Eat a burger");
            Todo todo2 = TodoItems.AddNewTodo("Buy another beer");
            Todo todo3 = TodoItems.AddNewTodo("Get a coffee");
            Todo todo4 = TodoItems.AddNewTodo("Send dad a bottle");

            //Act
            Todo[] todoArray = TodoItems.FindAll();
            todoArray[1].Done = true;
            todoArray[3].Done = true;
            Todo[] doneArray = TodoItems.FindByDoneStatus(true);
            //Assert
            Assert.Equal(todoArray[1].TodoId, doneArray[0].TodoId);
            Assert.Equal(todoArray[3].TodoId, doneArray[1].TodoId);
        }

        [Fact]
        public void FindByAssigneeStatus_Ok()
        {
            //Arrange
            Todo todo1 = TodoItems.AddNewTodo("Eat a burger");
            Todo todo2 = TodoItems.AddNewTodo("Buy another beer");
            Todo todo3 = TodoItems.AddNewTodo("Get a coffee");
            Todo todo4 = TodoItems.AddNewTodo("Send dad a bottle");



            //Act
            Person todoPerson = People.AddNewPerson("Bengan","Anderssen");
            Todo[] todoArray = TodoItems.FindAll();
            todoArray[0].Assignee = todoPerson;
            todoArray[2].Assignee = todoPerson;

            Todo[] findByAssigneeArray = TodoItems.FindByAssignee(todoPerson.PersonId);
            
            //Assert
            
            Assert.Equal(todoPerson, findByAssigneeArray[0].Assignee);
            Assert.Equal(todoPerson, findByAssigneeArray[1].Assignee);
        }
    }
}
