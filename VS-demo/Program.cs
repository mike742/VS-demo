using System;
using static System.Console;
using ClassLibrary1;
using System.Collections.Generic;
// using VS_demo1;

namespace VS_demo
{
    interface IPrintable
    {
        void Print();
    }

    interface IScanable : IPrintable
    {
        void Scan();
    }

    interface I1
    {
        void Print();
    }

    interface I2
    {
        void Print();
    }

    abstract class MyClass
    {
        #region Fields
        private int _id;
        private string _name;
        private string _name2;
        private string _name3;
        private string _name444;
        private string _name5;
        private string _name6;
        #endregion

        #region Properties
        protected int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Name2 { get => _name2; set => _name2 = value; }
        public string Name3 { get => _name3; set => _name3 = value; }
        public string Name6 { get => _name6; set => _name6 = value; }
        #endregion

        #region Methods
        public void Print()
        {
            WriteLine("Print Method");
        }

        public void Print2()
        {
            WriteLine("Print Method");
        }

        public void Print3()
        {
            WriteLine("Print Method");
        }

        public void Print4()
        {
            WriteLine("Print Method");
        }
        public void Print5()
        {
            WriteLine("Print Method");
        }
        public void Print6()
        {
            WriteLine("Print Method");
        }
        public void Print7()
        {
            WriteLine("Print Method");
        }
        #endregion

        public abstract void AbsPrint();
    }

    class MyClass2 : MyClass // internal
    {
        public override void AbsPrint()
        {
            WriteLine( Id ) ;
        }
    }

    public class Program : I1, I2
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.Print();
            // p.Scan();

            ((I1)p).Print();
            ((I2)p).Print();

            MyClass2 c = new MyClass2();
            c.Print();
            
        }

        public static List<int> Primes(int n)
        {
            var primes = new List<int>();

            for (int i = 2; i <= n; ++i)
            {
                while (n % i == 0)
                {
                    primes.Add(i);
                    n /= i;
                }
            }

            return primes;
        }

        public void Scan()
        {
            WriteLine("Do scanning");
        }

        void I2.Print()
        {
            WriteLine("Do printing I2");
        }

        void I1.Print()
        {
            WriteLine("Do Print I1");
        }

    }
}


