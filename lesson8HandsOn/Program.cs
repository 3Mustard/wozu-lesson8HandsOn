using System;

namespace lesson8HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            Cow cow1 = new Cow();

            d1.Speak();
            d1.Run();
            c1.Speak();
            c1.Run();
            cow1.Speak();
            cow1.Run();
        }

        public interface IMammel
        {
            void Speak();
            void Run();
        }

        public class Dog : IMammel
        { 
            public void Speak()
            {
                Console.WriteLine("Bark!");
            }

            public void Run()
            {
                Console.WriteLine("Dogs can run at a top speed of 45 mph!");
            }
        }
        public class Cat : IMammel
        {
            public void Speak()
            {
                Console.WriteLine("Meow!");
            }

            public void Run()
            {
                Console.WriteLine("Cats can run at a top speed of 30 mph!");
            }
        }
        public class Cow : IMammel
        {
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
