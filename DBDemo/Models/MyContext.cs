using Microsoft.EntityFrameworkCore;

namespace DBDemo.Models
{
    // inheriting from DbContext class
    public class MyContext : DbContext
    {
        // invoking the parent class's constructor inside the constructor
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Hat> Hats {get;set;}

        public DbSet<Person> People {get;set;}
    }
}