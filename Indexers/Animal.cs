using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Animal
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{id}{Name}{Age}";
        }
    }
}
