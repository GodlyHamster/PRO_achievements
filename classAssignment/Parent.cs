using System;
namespace classAssignment
{
    public class Parent : Person
    {
        public Parent(string name, string message) : base(name)
        {
            Console.WriteLine(name + " says: " + message);
        }
    }
}
