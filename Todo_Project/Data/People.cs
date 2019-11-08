using System;
using System.Collections.Generic;
using System.Text;
using Todo_Project.Model;
using System.Collections.Generic;


namespace Todo_Project.Data
{
    public class People
    {
        
        private static Person[] personArray = new Person[0];
        public int Size()
        {
            return personArray.Length;
        }
        public Person[] FindAll()
        {
            return personArray;
        }
        public Person FindById(int personId)
        {
           foreach (Person person in personArray)
            {
                if (personId==person.PersonId)
                {
                return person;
                }              
            }
            return null;
        }
        public Person AddNewPerson(string firstname,string lastname)
        {
            List<Person> personList = new List<Person>();
            Person newPerson = new Person(firstname,lastname);
            for (int i = 0; i < personArray.Length; i++)
            {
                personList[i] = personArray[i];
            }
            personList.Add(newPerson);
            Person[] newPersonArray = personList.ToArray();
            personArray = newPersonArray;
            return newPerson;
        }
        public void Clear()
        {
            Person[] personArrayEmpty = new Person[0];
            personArray=personArrayEmpty;
            PersonSequencer.Reset();
        }
       
    }
}
