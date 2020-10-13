using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Custromer
    {
        string _firstName;
        string _lastName;

        public Custromer() : this("no name", "no name") { }

        public Custromer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("{0} {1}", _firstName, _lastName);
        }

        ~Custromer()
        {
            Console.WriteLine("this is the Desctuctor!!!!");
        }
    }

}
