using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tubs.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}