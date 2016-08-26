using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleSearchWebApplication.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
    }
}