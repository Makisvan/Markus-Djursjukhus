using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markus_Djursjukhus
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }
        public int NumberOfLegs { get; set; }

        public Animal(string name, string species, int age, bool isVaccinated, int numberOfLegs)
        {
            Name = name;
            Species = species;
            Age = age;
            IsVaccinated = isVaccinated;
            NumberOfLegs = numberOfLegs;
        }

        public override string ToString()
        {
            return $"{Name} ({Species}, {Age} år)";
        }
    }
}
