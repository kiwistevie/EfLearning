using Sisak.EfLearning.Domain;
using System;
using System.Collections.Generic;

namespace Sisak.EfLearning.Dal
{
    public interface IPersonDao
    {
        List<Person> GetAll();
        Person GetById(int id);
        void InsertPerson(Person p);
        void DeletePerson(Person p);
        void UpdatePerson(Person p);
    }
}
