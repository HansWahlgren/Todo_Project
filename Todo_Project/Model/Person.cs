using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_Project.Model
{
    public class Person
    {
        private string firstName;
        private string lastName;
        public int PersonId { get; private set; }
        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            
            private set
            {
                bool checkLetter = true;
                if (value.Length > 0 && value.Length < 60 && value != null)
                {
                    foreach (var item in value)
                    {
                        if (!char.IsLetter(item))
                        {
                            checkLetter=false; 
                        }
                    }
                    if (checkLetter)
                    {
                        firstName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name can only contain letters.");
                    }
                }
                else
                {
                    throw new ArgumentException("Name is too long or short.");
                }            
            }
        
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            private set
            {
                bool checkLetter = true;
                if (value.Length > 0 && value.Length < 60 && value != null)
                {

                    foreach (var item in value)
                    {
                        if (!char.IsLetter(item))
                        {
                            checkLetter = false;
                        }
                    }
                    if (checkLetter)
                    {
                        lastName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name can only contain letters.");
                    }
                }
                else
                {
                    throw new ArgumentException("Name is too long or short.");
                }
            }

        }
        
        
        public Person (string firstname, string lastname) //Constructor
        {
            PersonId=1;
            //PersonId = PersonSequencer.NextPersonId;
            FirstName = firstname;
            LastName = lastname;

        }
    }
}
