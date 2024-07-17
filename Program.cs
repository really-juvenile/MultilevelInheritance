using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Walk();
            myDog.Bark();
        }
        public class Animal //this is  the base class or parent class
        {
            public void Eat()
            {
                Console.WriteLine("The animal is eating.");
            }
        }

        public class Mammal : Animal //mammal class has been derived from animal class
        {
            public void Walk()
            {
                Console.WriteLine("The mammal is walking.");
            }
        }

        public class Dog : Mammal //the derived class has been derived into  child class .
            //this is also called as heirarchical inheritance.
            //here dog is been derived from Mammal
        {
            public void Bark()
            {
                Console.WriteLine("The dog is barking.");
            }
        }
    }
}
