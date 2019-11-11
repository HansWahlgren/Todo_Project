using System;
using System.Collections.Generic;
using System.Text;
using Todo_Project.Model;

namespace Todo_Project.Data
{
    public class People
    {
        
        private static Person[] personArray = new Person[0];
        public static int Size()
        {
            return personArray.Length;
        }
        public static Person[] FindAll()
        {
            return personArray;
        }
        public static Person FindById(int personId)
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
        public static Person AddNewPerson(string firstname,string lastname)
        {
            List<Person> personList = new List<Person>(); //Created a new list to uppdate personArray
            Person newPerson = new Person(firstname,lastname);
            for (int i = 0; i < personArray.Length; i++)
            {
                personList.Add(personArray[i]);
            }
            personList.Add(newPerson);
            Person[] newPersonArray = personList.ToArray(); 
            personArray = newPersonArray;
            return newPerson;
        }
        public static void Clear()
        {
            Person[] personArrayEmpty = new Person[0];
            personArray=personArrayEmpty;
            PersonSequencer.Reset();
        }
        public static void RemovePerson(int indexNumber)
        {
            List<Person> nonRemovedPeopleList = new List<Person>(); //Created a new list to uppdate personArray
            for (int i = 0; i < personArray.Length; i++)
            {
                if (personArray[i].PersonId == indexNumber)
                {
                    Array.Clear(personArray, i, 1);
                }
                else
                {
                    nonRemovedPeopleList.Add(personArray[i]);
                }
            }
            Person[] newPersonArray = nonRemovedPeopleList.ToArray();
            personArray = newPersonArray;
        }
    }
}
