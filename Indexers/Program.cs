using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Names names = new Names();
            names.Add("Roman"); //1
            names.Add("Anna"); //2
            names.Add("Jarek"); //3
            //int i = names["Anna"]; // i ==2
            //names["Jarek"] = 1;
            names["Damian"] = 9;
            int x = names["Roman"];
            int y = names["Anna"];
            int z = names["Jarek"];
            int a = names["Damian"];
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(names.Lenght);
            Console.Read();

        }
    }
}
