using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBDemo.Models
{
    public class Person
    {
        [Key]
        public int PersonId {get;set;}

        public string FirstName {get;set;}

        public string LastName {get;set;}

        public string Email {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Hat> Hats {get;set;}
    }
}