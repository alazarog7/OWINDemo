﻿using SelfHosted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHosted
{
    public class PeopleController : ApiController
    {
        // GET api/People
        public IEnumerable<Person> Get()
        {
            return PeopleService.GetPeople();
        }

        // GET api/People/{id}
        public Person Get(int id)
        {
            Person person = PeopleService.GetPerson(id);
            return PeopleService.GetPerson(id);
        }

        // POST api/People
        public void Post(Person person)
        {
            PeopleService.AddPerson(person);
        }

        // PUT api/People/{id}
        public void Put(int id, Person person)
        {
            PeopleService.UpdatePerson(id, person);
        }

        // DELETE api/People/{id}
        public void Delete(int id)
        {
            PeopleService.DeletePerson(id);
        }
    }
}
