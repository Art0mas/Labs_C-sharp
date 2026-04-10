using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class AnimalManager
    {
        AnimalStorage animalStorage = new AnimalStorage();
        private List<Animal> animals = new List<Animal>();
        public void Run()
        {
            AddAnimals();
            ShowAnimals();
        }

        private void AddAnimals()
        {
            Animal dog1 = new Dog { Name = "Тузік", BarkVolume = 10 };
            Animal dog2 = new Dog { Name = "Бобік", BarkVolume = 7 };
            Animal cat1 = new Cat { Name = "Мурчик", Lives = 9 };
            Animal cat2 = new Cat { Name = "Барсік", Lives = 7 };
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(cat1);
            animals.Add(cat2);
            animalStorage.Save(animals);
        }
        public void ShowAnimals()
        {
            List<Animal> animals = animalStorage.Load();
            foreach(var animal in animals)
            {
                if(animal is Dog dog)
                {
                    Console.WriteLine($"Пес [Ім'я: {dog.Name}, Сила гавкання: {dog.BarkVolume}]");
                }
                else if(animal is Cat cat)
                {
                    Console.WriteLine($"Кіт [Ім'я: {cat.Name}, Кількість життів: {cat.Lives}]");
                }
            }
        }

    }
}
