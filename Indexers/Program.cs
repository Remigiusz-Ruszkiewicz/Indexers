using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Indexers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var users = new List<AnimalUser>();
            XDocument ducument = XDocument.Load("test.xml");
            List<XElement> elements = document.Element("Root").Elements().ToList();
            elements.ForEach(e =>
            {
                var user = new AnimalUser
                {
                    Id = int.Parse(e.Attribute("Id").Value),
                    Name = e.Attribute("Name").Value,
                    Role = e.Attribute("Role").Value,
                    Password = e.Attribute("Password").Value

                };
                users.Add(user);
            });
            Console.Read();







            //Names names = new Names();
            //names.Add("Roman"); //1
            //names.Add("Anna"); //2
            //names.Add("Jarek"); //3
            ////int i = names["Anna"]; // i ==2
            ////names["Jarek"] = 1;
            //names["Damian"] = 9;
            //int x = names["Roman"];
            //int y = names["Anna"];
            //int z = names["Jarek"];
            //int a = names["Damian"];
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(names.Lenght);
            //List<Animal> animalson = new List<Animal>();
            //List<Country> countries = new List<Country>();
            //countries.Add(new Country { CountryId = 1, Name = "Polska" });
            //countries.Add(new Country { CountryId = 2, Name = "Anglia" });

            //xd(animalson);
            //var polskieZwierzaki = animalson.Join(countries,
            //    animal => animal.CountryId,
            //    country => country.CountryId,
            //    (animal, country) => new
            //    {
            //        Id = animal.id,
            //        Name = animal.Name,
            //        Age = animal.Age,
            //        CountryName = country.Name,
            //        CountryId = animal.CountryId
            //    })
            //    .Select(a=> new Animal
            //    {
            //        Name =a.Name,
            //        id = a.Id,
            //        Age = a.Age,
            //        CountryId = a.CountryId
            //    })
            //    .Where(a=> a.CountryId==2)
            //    .ToList();


            //polskieZwierzaki.ForEach(a =>
            //{
            //    Console.WriteLine(a);
            //});
            //IEnumerable<Animal> elefants = from animals in animalson
            //                               where animals.Name == "Słoń"
            //                               select animals;
            //IEnumerable<Animal> elefants = from animals in animalson
            //                               where animals.id < 4 && animals.Age >20 || animals.Age%2 ==0
            //                               select animals;

            //var ń = animalson
            //    .Where(a => a.Name.Contains("ń"))
            //    .Select(a => a.Name)
            //    .Distinct()
            //    .ToList();
            //Console.WriteLine(elefants.FirstOrDefault());
            //Console.WriteLine(elefants.Count());
            //Console.WriteLine(elefants.LastOrDefault());
            //Console.WriteLine(elefants.SingleOrDefault());

            //foreach (var item in elefants)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(ń);
            //double avg = elefants.Average(e => e.Age);
            //int max = elefants.Max(e => e.Age);
            //int min = elefants.Min(e => e.Age);
            //int sum = elefants.Sum(e => e.Age);
            //int sum1 = elefants.Select(a => a.Age).Sum();


            //var cos = elefants.(e => new
            //{
            //    e.Name
            //}).Select(g => new { Name = g.Key, Age = g.Sum(a => a.Age) });
            //Console.WriteLine(group.FirstOrDefault());
            //List<Animal> toRemove = elefants.ToList();
            //var toAdd = elefants.ToList();
            //animalson.AddRange(toAdd)
            //animalson.ForEach(a =>
            //   {
            //       Console.WriteLine(a);
            //   }
            //   );

            Console.Read();
        }


        private static void xd(List<Animal> animals)
        {
            animals.Add(new Animal
            {
                id = 1,
                Name = "Słoń",
                Age = 13,
                CountryId = 1
            });
            animals.Add(new Animal
            {
                id = 4,
                Name = "Słoń",
                Age = 15,
                CountryId = 2
            });
            animals.Add(new Animal
            {
                id = 2,
                Name = "Koń",
                Age = 13,
                CountryId = 2
            });
            animals.Add(new Animal
            {
                id = 3,
                Name = "Małpa",
                Age = 24,
                CountryId = 1
            });
        }
    }
}
