using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Dog bulldog = new Dog();
            Cat kitten = new Cat();

            ani.MakeSound();
            bulldog.MakeSound();
            kitten.MakeSound();
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic Sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

}