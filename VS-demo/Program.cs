using System;
using static System.Console;
using ClassLibrary1;

namespace VS_demo
{
    class Empoyee
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        //ctor

        public Empoyee() : this("n/a", "n/a") { }
        public Empoyee(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public void PrintFullName()
        {
            WriteLine("{0} {1}", FirstName, LastName);
        }
    }

    class FullTimeEmployee : Empoyee
    {
        public float YearSalary { set; get; }
    }

    class PartTimeEmployee : Empoyee
    {
        public float HourlyRate { set; get; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.SetId(101);
            Console.WriteLine(s.GetId() + " " + s.GetName());
            // s.Name = null;
            // s.PassMark = 0;

            s.Id = 102;
            s.Name = "John";

            s.City = "Winnipeg";
            s.Email = "ddd@ddd.com";

            Console.WriteLine(s.Id + " " + s.Name + " " + s.City + " " + s.Email);


            PartTimeEmployee e1 = new PartTimeEmployee();
            FullTimeEmployee e2 = new FullTimeEmployee();

            e1.HourlyRate = 15;
            e2.YearSalary = 30000;

            e1.PrintFullName();
        }
    }
}


