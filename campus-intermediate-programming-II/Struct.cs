using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campus_intermediate_programming_II
{
    public class Struct
    {
        public int K { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }

        public Struct(int k, string name, string pass)
        {
            K = k;
            Name = name;
            Pass = pass;
        }
    }
}
