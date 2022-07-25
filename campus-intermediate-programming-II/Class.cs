using System;

namespace campus_intermediate_programming_II
{
    public class Class
    {
        public int K { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }

        public Class(int k, string name, string pass)
        {
            K = k;
            Name = name;
            Pass = pass;
        }
    }
}
