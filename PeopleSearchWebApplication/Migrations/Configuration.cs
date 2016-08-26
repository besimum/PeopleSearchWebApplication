//namespace PeopleSearchWebApplication.Migrations
namespace PeopleSearchWebApplication.DAL
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    //internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearchWebApplication.DAL.PeopleContext>
      public class Configuration : System.Data.Entity.DropCreateDatabaseAlways<PeopleContext>
    {
        /*public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            PeopleContext = "PeopleSearchWebApplication.DAL.PeopleContext";
        }*/

        //protected override void Seed(PeopleSearchWebApplication.DAL.PeopleContext context)
        protected override void Seed(PeopleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var persons = new List<Person>
            {
                new Person() { Id = 4, Salutation = "Mr", FirstName = "Benjamin", MiddleInitial = "S",
                    LastName = "Mutuku", JobTitle = "Software Engineer" },
                new Person() { Id = 5, Salutation = "Mr", FirstName = "Charles", MiddleInitial = "M",
                    LastName = "Whitmore", JobTitle = "Explorer Analyst" },
                new Person() { Id = 6, Salutation = "Miss", FirstName = "Salome", MiddleInitial = "M",
                    LastName = "Mutuku", JobTitle = "Businesswoman" },
                new Person() { Id = 7, Salutation = "Miss", FirstName = "Rebecca", MiddleInitial = "M",
                    LastName = "Sila", JobTitle = "President" }
            };

            persons.ForEach(p => context.Person.Add(p));
            context.SaveChanges();

        }
    }
}
