using System;
using System.Collections.Generic;
using System.Text;
using Todo_Project.Data;
using Todo_Project.Model;

namespace Todo_Project.Data
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0];
        public static int Size()
        {
            return todoArray.Length;
        }
        public static Todo[] FindAll()
        {
            return todoArray;
        }
        public static Todo FindById(int TodoId)
        {
            foreach (Todo todo in todoArray)
            {
                if (TodoId == todo.TodoId)
                {
                    return todo;
                }
            }
            return null;
        }
        public static Todo AddNewTodo(string description)
        {
            List<Todo> todoList = new List<Todo>();
            Todo newTodo = new Todo(description);
            for (int i = 0; i < todoArray.Length; i++)
            {
                todoList.Add(todoArray[i]);
            }
            todoList.Add(newTodo);
            Todo[] newTodoArray = todoList.ToArray();
            todoArray = newTodoArray;
            return newTodo;
        }
        public static void Clear()
        {
            Todo[] todoArrayEmpty = new Todo[0];
            todoArray = todoArrayEmpty;
            PersonSequencer.Reset();
        }
        public static Todo[] FindByDoneStatus(bool doneStatus)
        {
            List<Todo> doneStatusList = new List<Todo>();
            
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Done == doneStatus)
                {
                    doneStatusList.Add(todoArray[i]);
                }
            }
            Todo[] newDoneArray = doneStatusList.ToArray();
            return newDoneArray;            
        }
        public static Todo[] FindByAssignee(int personId)
        {
            List<Todo> AssigneeList = new List<Todo>();

            for (int i = 0; i < todoArray.Length; i++)
            {
                if(todoArray[i].Assignee != null)
                {
                    if (todoArray[i].Assignee.PersonId == personId)//jämför med null
                    {
                        AssigneeList.Add(todoArray[i]);
                    }
                }
            }
            Todo[] newAssigneeArray = AssigneeList.ToArray();
            return newAssigneeArray;
        }

        public static Todo[] FindByAssignee(Person assignee)
        {
            List<Todo> AssigneeList = new List<Todo>();

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Assignee != null)
                {
                    if (todoArray[i].Assignee.PersonId == assignee.PersonId)
                    {
                        AssigneeList.Add(todoArray[i]);
                    }
                }
            }
            Todo[] newAssigneeArray = AssigneeList.ToArray();
            return newAssigneeArray;
        }

        public static Todo[] FindUnassignedTodoItems()
        {
            List<Todo> unAssignedList = new List<Todo>();

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Assignee == null)
                {
                    unAssignedList.Add(todoArray[i]);
                }
            }
            Todo[] newAssigneeArray = unAssignedList.ToArray();
            return newAssigneeArray;
        }
        public static void RemoveTodoItem(int indexNumber)
        {
            List<Todo> nonRemovedTodoList = new List<Todo>();
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].TodoId == indexNumber)
                {
                    Array.Clear(todoArray,i,1);
                }
                else
                {
                    nonRemovedTodoList.Add(todoArray[i]);
                }
            }
            Todo[] newTodoArray = nonRemovedTodoList.ToArray();
            todoArray = newTodoArray;
        }
    }
}
