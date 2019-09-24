using System;
using System.Collections.Generic;
using System.Linq;

namespace Indexers
{
    internal class Program
    {
        private static void Main(string[] args)
        {

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
            List<Animal> animalson = new List<Animal>();
            xd(animalson);
            IEnumerable<Animal> elefants = from animals in animalson
                                           where animals.Name == "Słoń"
                                           select animals;
            Console.WriteLine(elefants.FirstOrDefault());
            Console.WriteLine(elefants.Count());
            Console.WriteLine(elefants.LastOrDefault());
            //Console.WriteLine(elefants.SingleOrDefault());
            double avg = elefants.Average(e => e.Age);
            int max = elefants.Max(e => e.Age);
            int min = elefants.Min(e => e.Age);
            int sum = elefants.Sum(e => e.Age);
            int sum1 = elefants.Select(a => a.Age).Sum();


            var group = elefants.GroupBy(e => new
            {
                e.Name
            }).Select(g=>new {Name = g.Key ,Age = g.Sum(a=> a.Age) });
            Console.WriteLine(group.FirstOrDefault());
            Console.Read();
        }

        private static void xd(List<Animal> animals)
        {
            animals.Add(new Animal
            {
                id = 1,
                Name = "Słoń",
                Age = 13
            });
            animals.Add(new Animal
            {
                id = 4,
                Name = "Słoń",
                Age = 15
            });
            animals.Add(new Animal
            {
                id = 2,
                Name = "Koń",
                Age = 13
            });
            animals.Add(new Animal
            {
                id = 3,
                Name = "Małpa",
                Age = 13
            });
        }
    }
}
