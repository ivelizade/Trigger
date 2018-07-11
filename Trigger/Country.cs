using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigger
{
   public class Country
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Country(string name, string shortname)
        {
            Name = name;
            ShortName = shortname;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
