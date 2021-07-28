using SelfHosted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHosted
{
    public static class PeopleService
    {
        private static List<Person> peopleList = new List<Person>(
            new Person[] {
                new Person()
                {
                    ID = 1,
                    Name = "Michael",
                    DateOfBirth = "20/05/1960"
                },
                new Person()
                {
                    ID = 2,
                    Name = "Jim",
                    DateOfBirth = "15/06/1980"
                },
                new Person()
                {
                    ID = 3,
                    Name = "Dwight",
                    DateOfBirth = "05/12/1977"
                }
            });

        public static List<Person> GetPeople()
        {
            return peopleList;
        }
        public static Person GetPerson(int id)
        {
            return peopleList
                .Where(person => person.ID == id)
                .FirstOrDefault();
        }
        public static void AddPerson(Person person)
        {
            peopleList.Add(person);
        }
        public static void UpdatePerson(int id, Person personUpdate)
        {
            Person findPerson = peopleList
                .Where(person => person.ID == id)
                .FirstOrDefault();
            if(findPerson != null)
            {
                findPerson.Name = personUpdate.Name;
                findPerson.DateOfBirth = personUpdate.DateOfBirth;
            }
        }

        public static void DeletePerson(int id)
        {
            Person findPerson = peopleList
                .Where(person => person.ID == id)
                .FirstOrDefault();
            if (findPerson != null)
            {
                peopleList.Remove(findPerson);
            }
        }
    }
}
