using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_ArvoresBasicas
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Role { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Role})";
        }
    }
}