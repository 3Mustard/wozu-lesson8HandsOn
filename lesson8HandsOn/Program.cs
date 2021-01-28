using System;

namespace lesson8HandsOn
{
    class Program
    {
        // MAIN METHOD
        static void Main(string[] args)
        {
            // declare variables and instantiate new objects
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            Cow cow1 = new Cow();

            // use methods inherited by interfaces
            d1.Speak();
            d1.Run();
            d1.Eat();
            c1.Speak();
            c1.Run();
            c1.Eat();
            cow1.Speak();
            cow1.Run();
            cow1.Eat();
        }
        // INTERFACES

        public interface IAnimal
        {
            void Eat();
        }
        public interface IMammel
            : IAnimal
        {
            void Speak();
            void Run();
        }

        // CLASSES

        // DOG
        public class Dog 
            : IMammel
        {
            public void Eat()
            {
                Console.WriteLine("Dogs eat bones.");
            }

            public void Speak()
            {
                Console.WriteLine("Bark!");
            }

            public void Run()
            {
                Console.WriteLine("Dogs can run at a top speed of 45 mph!");
            }
        }
        // CAT
        public class Cat 
            : IMammel
        {
            public void Eat()
            {
                Console.WriteLine("Cats eat mice.");
            }

            public void Speak()
            {
                Console.WriteLine("Meow!");
            }

            public void Run()
            {
                Console.WriteLine("Cats can run at a top speed of 30 mph!");
            }
        }
        // Cow
        public class Cow 
            : IMammel
        {
            public void Eat()
            {
                Console.WriteLine("Cows eat grass.");
            }

            public void Speak()
            {
                Console.WriteLine("Moo!");
            }

            public void Run()
            {
                Console.WriteLine("Cows can run at a top speed of 25 mph!");
            }
        }
    }
}
