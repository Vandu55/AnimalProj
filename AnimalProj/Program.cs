using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProj
{
    abstract class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void Makesound();

    }
    class Dog : Animal
    {
        public Dog(string name, int age) :
            base(name, age)
        { }

        public override void Makesound()
        {
            Console.WriteLine("woof");
        }

        public void Fetch()
        {
            Console.WriteLine("Fetching");
        }
    }

    class Cat : Animal
    {
        public Cat(string name,int age) : base(name, age) { }
        public override void Makesound()
        {
            Console.WriteLine("meow!");
        }
        public void purr()
        {
            Console.WriteLine("purring softly");
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("buddy", 3);
            Cat c = new Cat("whishers", 5);


            Console.WriteLine($"Dog Name:{d.Name},Age:{d.Age}");
            d.Makesound();
            d.Fetch();

            Console.WriteLine($"cat Name:{c.Name},Age:{c.Age}");
            c.Makesound();
            c.purr();

        }
    }

}
