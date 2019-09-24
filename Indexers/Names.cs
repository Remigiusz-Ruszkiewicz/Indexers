using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Names
    {
        List<string> nameList = new List<string>();
        public void Add(string name)
        {
            nameList.Add(name);
        }
        public int Lenght
        {
            get
            {
                return nameList.Count;
            }
        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < nameList.Count; i++)
                {
                    if (nameList[i] == name)
                    {
                        return i + 1;
                    }
                }
                return 0;
            }
            set
            {
                for (int i = 0; i < nameList.Count; i++)
                {
                    if (i == value)
                    {
                        nameList[i] = name;
                        return;
                    }
                }
                if (value > nameList.Count -1)
                {
                    for (int i = nameList.Count -1 ;i < value; i++)
                    {
                        nameList.Add(null);
                    }
                    nameList[value] = name;
                    return;
                }
                nameList.Add(name);
            }
        }
    }
}
