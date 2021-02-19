using System;
using System.ComponentModel.DataAnnotations;

namespace DBDemo.Models
{
    public class Hat
    {
        [Key]
        public int HatId {get;set;}

        public string Color {get;set;}

        public string Brand {get;set;}

        public bool Adjustable {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // references the owner's ID
        // foreign key
        public int PersonId {get;set;}

        // navigation property
        public Person Owner {get;set;}
    }
}