using System;

namespace HelloWorld
{
    public class Animal
    {
        private string species;

        public string Species { get => species; set => species = value; }

        public Animal(string Species)
        {
            this.Species = Species;
        }
        public void publicMethod(){
             Console.WriteLine("This method is accessible by outside classes");
        }

        private void privateMethod(){
             Console.WriteLine("This method is only accessible inside this class");
        }

        protected void protectedMethod(){
             Console.WriteLine("This method is only accessible inside this project");
        }
    }
}