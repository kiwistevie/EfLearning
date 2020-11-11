using Sisak.EfLearning.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sisak.EfLearning.Dal
{
    public interface IDeviceDao
    {
        List<Device> GetAll();
        Device GetById(int id);
        List<Device> GetByOwner(Person p);
    }
}
