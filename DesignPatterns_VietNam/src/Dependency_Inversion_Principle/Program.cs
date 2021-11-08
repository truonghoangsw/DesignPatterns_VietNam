using System;

namespace Dependency_Inversion_Principle
{
    class Research
    {
        public Research(IRelationshipsBrowser browser)
        {
            foreach (var person in browser.FindAllChildrenOf("truong"))
                Console.WriteLine($"Truong has a child called {person.Name}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
