using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sisak.EfLearning.Dal.Ef
{
    public class EfDaoFactory : IDaoFactory
    {
        private readonly PeopleContext _context;

        public EfDaoFactory(string connectionString)
        {
            var dbContextBuilder = new DbContextOptionsBuilder();
            dbContextBuilder.UseSqlServer(connectionString);
            _context = new PeopleContext(dbContextBuilder.Options);
        }

        public IDeviceDao CreateDeviceDao()
        {
            throw new NotImplementedException(); 
        }

        public IPersonDao CreatePersonDao()
        {
            return new EfPersonDao(_context);
        }
    }
}
