using System;
using System.Collections.Generic;

namespace Sisak.EfLearning.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adress Adress { get; set; }
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}
