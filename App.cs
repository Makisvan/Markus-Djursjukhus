using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Markus_Djursjukhus
    {
        public class App
        {
        public static void Run()
        {
            List<Animal> animals = new List<Animal>
        {
            new Animal("Markus", "Bird", 2, true, 30),
            new Animal("Oliver", "Cat", 4, true, 4),
            new Animal("Amanda", "Dog", 3, true, 4),
            new Animal("Shadow", "Turtle", 4, false, 4),
            new Animal("Nala", "Dog", 4, true, 4),
            new Animal("Ollas", "Bird", 1, true, 2),
            new Animal("Pajaso", "Dog", 10, false, 4),
            new Animal("Gandalf", "Cat", 8, true, 4),
            new Animal("Tony", "Horse", 12, true, 4),
            new Animal("Bigo", "Horse", 6, true, 4),
            new Animal("Julius", "Snake", 9, false, 0)
        };

            int numberOfDogs = animals.Count(a => a.Species == "Dog");
            Console.WriteLine($"Antal hundar: {numberOfDogs}");
            Console.WriteLine();

            Animal oldestAnimal = animals.OrderByDescending(a => a.Age).FirstOrDefault();
            Console.WriteLine($"Äldsta djuret: {oldestAnimal}");
            Console.WriteLine();

            List<Animal> vaccinatedAnimals = animals.Where(a => a.IsVaccinated).ToList();
            Console.WriteLine("Vaccinerade djur:");
            vaccinatedAnimals.ForEach(a => Console.WriteLine(a));
            Console.WriteLine();

            List<Animal> animalsWith4LegsOver3Years = animals
                .Where(a => a.NumberOfLegs == 4 && a.Age > 3)
                .ToList();
                Console.WriteLine("Djur med 4 ben över 3 år gamla:");
                animalsWith4LegsOver3Years.ForEach(a => Console.WriteLine(a));
            Console.WriteLine();

            bool existsShadow = animals.Any(a => a.Name == "Shadow");
            Console.WriteLine($"Finns det ett djur som heter Shadow? {existsShadow}");
        }
    }
}
