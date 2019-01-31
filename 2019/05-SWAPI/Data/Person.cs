using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SWAPI.Data
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\t" + 
                   $"Gender: {Gender}\t" +
                   $"Height: {Height}";
        }
    }
}
