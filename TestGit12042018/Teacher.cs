using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit12042018
{
    class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"The teachers name {Name}";
        }
    }
}
