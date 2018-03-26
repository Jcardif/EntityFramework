using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context=new PersonConnetionString())
            {
                IQueryable<person> query = context.people.Where(p => p.FirstName.StartsWith("J"));
                List<person> persons = query.ToList();
                Console.WriteLine(persons.Count);
            }
        }
    }
}
