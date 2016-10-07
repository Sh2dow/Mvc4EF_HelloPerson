using System.Data.Entity;
using Mvc4EF_HelloPerson.Models;

namespace Mvc4EF_HelloPerson.Logic
{
    public class PersonsContext : DbContext
    {
        public PersonsContext()
            : base("name=PersonContext")
        {
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Person> Persons { get; set; }
    }
}