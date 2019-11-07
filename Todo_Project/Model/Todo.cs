using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_Project.Model
{
    public class Todo
    {
        private int todoId;
        private bool done;
        private string description;
        private Person assignee;

        public int TodoId { get; private set; }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (value.Length > 0 && value.Length < 500 && value != null)
                {
                        description = value;
                }
                else
                {
                    throw new ArgumentException("Description is too long or short.");
                }
            }
        }

        public Todo(string description) //Constructor
        {
            TodoId = 1;
            //TodoId = TodoSequencer.NextTodoId;
            Description = description;
        }
    }
}
