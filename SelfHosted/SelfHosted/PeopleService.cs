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
        public static Response AddPerson(Person person)
        {
            peopleList.Add(person);
            
            return new Response {
                Success = true,
                Data = person.ID.ToString()
            };
        }
        public static Response UpdatePerson(int id, Person personUpdate)
        {
            Person findPerson = peopleList
                .Where(person => person.ID == id)
                .FirstOrDefault();
            if (findPerson != null)
            {
                findPerson.Name = personUpdate.Name;
                findPerson.DateOfBirth = personUpdate.DateOfBirth;
                return new Response
                {
                    Success = true,
                    Data = personUpdate.ID.ToString()
                };
            }
            else
            {
                return new Response
                {
                    Success = false,
                    Data = "Person not found"
                };
            }
        }

        public static Response DeletePerson(int id)
        {
            Person findPerson = peopleList
                .Where(person => person.ID == id)
                .FirstOrDefault();
            if (findPerson != null)
            {
                peopleList.Remove(findPerson);
                return new Response
                {
                    Success = true,
                    Data = ""
                };
            }
            else
            {
                return new Response
                {
                    Success = false,
                    Data = "Person not found"
                };
            }
        }
    }
}
