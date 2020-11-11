using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sisak.EfLearning.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Sisak.EfLearning.Dal.Ef
{
    internal class PeopleContextFactory : IDesignTimeDbContextFactory<PeopleContext>
    {
        private class Configuration
        {
            public string ConnectionString { get; set; }
        }

        public PeopleContext CreateDbContext(string[] args)
        {
            string json = File.ReadAllText("appsettings.json");
            string connectionString = JsonSerializer.Deserialize<Configuration>(json)
                .ConnectionString;
            var dbContextBuilder = new DbContextOptionsBuilder();
            dbContextBuilder.UseSqlServer(connectionString);
            return new PeopleContext(dbContextBuilder.Options);
        }
    }
}
