using Sisak.EfLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sisak.EfLearning.Dal.Ef
{
    public class EfPersonDao : IPersonDao
    {
        private readonly PeopleContext peopleContext;

        internal EfPersonDao(PeopleContext peopleContext)
        {
            this.peopleContext = peopleContext;
        }

        public void DeletePerson(Person p)
        {
            peopleContext.People.Remove(p);
            peopleContext.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return peopleContext.People.ToList();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertPerson(Person p)
        {
            peopleContext.People.Add(p);
            peopleContext.SaveChanges();
        }

        public void UpdatePerson(Person p)
        {
            throw new NotImplementedException();
        }
    }
}
