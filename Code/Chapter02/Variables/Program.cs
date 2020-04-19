using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // double
            object name = "Amir"; // string
            Console.WriteLine($"{name} is {height} meters tall.");
            //int length1 = name.Length; // error
            int length2 = ((string)name).Length; // casting to string
            Console.WriteLine($"{name} has {length2} characters.");

            dynamic anotherName = "Ahmed";
            int length = anotherName.Length;

            int population = 66_000_000;
            double weight = 1.88; // kg
            decimal price = 4.99M ; // gbp
            string fruit = "Apples";
            char letter = 'Z';
            bool happy = true;
        }
    }
}
