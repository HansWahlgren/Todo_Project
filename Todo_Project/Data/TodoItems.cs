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
    }
}
