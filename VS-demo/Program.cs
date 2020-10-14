using System;
using static System.Console;
using ClassLibrary1;
using System.Collections.Generic;
// using VS_demo1;

namespace VS_demo
{

    public sealed class Empoyee
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
         // ASP.NET - web app
         // WPF 
        public  void PrintFullName() // virtual
        {
            WriteLine("{0} {1} - Base class PrintFN method", FirstName, LastName);
        }
    }
    class FullTimeEmployee : Empoyee
    {
        public float YearSalary { set; get; }

        public override void PrintFullName()
        {
            // base.PrintFullName();
            WriteLine("{0} {1} - FullTime", FirstName, LastName);
        }
    }

    class PartTimeEmployee : Empoyee
    {
        public float HourlyRate { set; get; }

        public override void PrintFullName()
        {
            WriteLine("{0} {1} - PartTime", FirstName, LastName);
        }
    }

    class TempEmployee : Empoyee
    {
        public override void PrintFullName()
        {
            WriteLine("{0} {1} - Temporary", FirstName, LastName);
        }
    }

    interface I1
    {
        void Method();
    }

    struct MyStruct : I1
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        /*
        public MyStruct()
        {
            _id = 0;
            _name = "no name";
        }
        */
        public MyStruct(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public void Print()
        {
            WriteLine("{0} - {1}", Id, Name);
        }

        public void Method()
        {
            // throw new NotImplementedException();
        }
    }

    class MyClass
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public MyClass()
        {
            
        }
        public MyClass(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public void Print()
        {
            WriteLine("{0} - {1}", Id, Name);
        }

        ~MyClass()
        { }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            /*
            PartTimeEmployee e1 = new PartTimeEmployee();
            FullTimeEmployee e2 = new FullTimeEmployee();
            Empoyee e = new Empoyee();

            e1.HourlyRate = 15;
            e2.YearSalary = 30000;

            e1.PrintFullName();
            e2.PrintFullName();
            e.PrintFullName();
            */

            List<Empoyee> le = new List<Empoyee>();

            le.Add(new Empoyee());
            le.Add(new PartTimeEmployee());
            le.Add(new FullTimeEmployee());
            le.Add(new TempEmployee());

            foreach (var e in le)
            {
                e.PrintFullName();
            }

            int test = 77;

            // Add(2, 3, out test);

            String str = String.Empty;
            string str2 = string.Empty;

            System.Int32 i = 55;

            Write("test = {0}", test);


            WriteLine("=====================================================================");
            MyStruct ms = new MyStruct() { Id = 101, Name = "Mark" };
            MyClass mc = new MyClass() { Id = 101, Name = "Mark" };

            MyStruct ms2 = ms;
            
            MyClass mc2 = mc;

            ms2.Name = "New Struct Mark";
            mc2.Name = "New Class Mark";

            ms.Print();
            ms2.Print();

            mc.Print();
            mc2.Print();
        }

        static void Add(int a, int b)
        {
            WriteLine(a + b);
        }
        /*
        static void Add(int a, int b, in int sum) // sum - read-only
        {
            // sum = a + b;
            WriteLine(a + b + sum);
        }
        */
        static void Add(int a, int b, ref int test) // ref - could be changed
        {
            // test = 55;
            WriteLine(a + b);
        }

        static void Add(int a, int b, out int test, int ddd) // out - should be changed
        {
            test = 55;
            WriteLine(a + b);
        }
        static void Add(int a, int b, int sum)
        {
            sum = a + b;
            WriteLine(sum);
        }
        static void Add(float a, int b)
        {
            WriteLine(a + b);
        }
    }
}


