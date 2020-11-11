using Microsoft.EntityFrameworkCore;
using Sisak.EfLearning.Domain;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sisak.EfLearning.Dal.Ef
{
    internal class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Device> Devices { get; set; }

        public PeopleContext(DbContextOptions options) : base(options)
        { }
    }
}
