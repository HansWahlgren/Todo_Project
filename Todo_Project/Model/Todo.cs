using System;
using System.Collections.Generic;
using System.Text;
using Todo_Project.Data;

namespace Todo_Project.Model
{
    public class Todo
    {
        private int todoId;
        private bool done;
        private string description;
        private Person assignee;

        public Person Assignee
        {
            get
            {
                return assignee;
            }
            set
            {
                assignee = value;
            }
        }

        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }

        public int TodoId
        { get
            {
                return todoId;
            }
            private set
            {
                todoId = value;
            }                
        }

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
            TodoId = TodoSequencer.NextTodoId();
            Description = description;
            Done = false;
        }
    }
}
