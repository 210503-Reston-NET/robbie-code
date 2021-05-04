using System;



// Naming Conventions for Artifacts == PascalCase; EveryFirstLetterIsCapitalizedForEachWord
// We use camel case for naming fields, but for the rest, PascalCase
namespace HelloWorld
{
    // This class is by default called program. <Starting Point = Contains 'Main' method>
    class Program
    {
        // First Method that gets called, Compiler looks for this method at Runtime
        static void Main(string[] args)
        {
            var something = 1;
            Console.WriteLine("Hello World!" + " " + something);

            int[] stuff = {1,2,3,4};

            foreach (int thing in stuff){
                Console.WriteLine(thing);
            }

            Animal animal= new Animal("Tiger");

            animal.publicMethod();
            // animal.protectedMethod();  Not Accessible due to protection level
            // animal.privateMethod();  Not Accessible due to protection level

            Console.WriteLine(animal.Species);

            animal.Species = "Lion";

            Console.WriteLine(animal.Species);
        }
    }
}
