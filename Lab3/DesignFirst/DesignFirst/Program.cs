using System;

namespace DesignFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPerson();
        }

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                var p = new Person
                {
                    FirstName = "Some First Name",
                    LastName = "Some Last name"
                };
                context.People.Add(p);
                context.SaveChanges();

                foreach(var x in context.People)
                {
                    Console.WriteLine("{0} {1}", x.FirstName, x.LastName);
                }
            }
        }
    }
}
