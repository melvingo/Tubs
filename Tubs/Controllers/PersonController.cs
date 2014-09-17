using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tubs.Models;

namespace Tubs.Controllers
{
    public class PersonController : ApiController
    {
        private List<Person> _persons;

        public PersonController()
        {
            _persons = new List<Person>
            {
                new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Melvin",
                    LastName = "Go",
                    DateOfBirth = new DateTime(1982, 3, 2)
                }
            };
        }

        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return _persons;
        }

        // GET: api/Person/5
        public Person Get(Guid id)
        {
            return _persons.SingleOrDefault(p => p.Id == id);
        }

        // POST: api/Person
        public void Post([FromBody]Person person)
        {

        }

        // PUT: api/Person/5
        public void Put(Guid id, [FromBody]Person person)
        {

        }

        // DELETE: api/Person/5
        public void Delete(Guid id)
        {

        }
    }
}
