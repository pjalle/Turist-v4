using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turist_App_v4.Model
{
    class Kategorier
    {
        public string Name { get; set; }
        public string Billede { get; set; }

        public Kategorier(string name, string billede)
        {
            Name = name;
            Billede = billede;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
