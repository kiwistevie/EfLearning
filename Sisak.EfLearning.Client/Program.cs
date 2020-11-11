using Sisak.EfLearning.Dal;
using Sisak.EfLearning.Dal.Ef;
using Sisak.EfLearning.Domain;
using System;
using System.IO;
using System.Text.Json;

namespace Sisak.EfLearning.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonConfig = File.ReadAllText("appsettings.json");
            Configuration config = JsonSerializer.Deserialize<Configuration>(jsonConfig);

            IDaoFactory daoFactory = new EfDaoFactory(config.ConnectionStrings.Default);
            IPersonDao personDao = daoFactory.CreatePersonDao();

            Person p = new Person
            {
                FirstName = "Stefan",
                LastName = "Isak",
                Adress = new Adress
                {
                    Street = "Peygarten-Ottenstein 56",
                    Country = "Austria"
                }
            };

            personDao.InsertPerson(p);

            foreach (var person in personDao.GetAll())
            {
                Console.WriteLine(
                    $"{person.FirstName} {person.LastName} from {person.Adress.Country}"
                );
            }
        }
    }
}
