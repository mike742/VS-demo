using System;
using System.Collections.Generic;
using static System.Console;


namespace VS_demo
{
    class Program 
    {
        static void Main(string[] args)
        {
            Adder newAdder = new Adder();

            dgPointer myDelegate = new dgPointer(Add);
            int sum = myDelegate(4, 3);

            Action myAction = new Action(newAdder.Method1);
            dgAction ddd = new dgAction(newAdder.Method2);

            myAction.Invoke();

            ddd.Invoke();

            WriteLine(sum);

            WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            newAdder.OnSumModFive += new Adder.dgEventRaiser(m_SumOnFive);

            int res = newAdder.Add2(4, 3);
            WriteLine("res = {0}", res);
            
            res = newAdder.Add2(4, 6);
            WriteLine("res = {0}", res);
        }

        static void m_SumOnFive()
        {
            WriteLine("Sum % 5 == 0");
        }


        public static void Something(int a, int b, dgPointer p)
        {
            p.Invoke(100, 200);
        }

        public static int Add(int a, int b) => a + b;
    }

    public delegate int dgPointer(int a, int b);
    public delegate string dgPointer2(int a, int b);
    public delegate List<string> dgPointer3(int a, int b);

    public delegate void dgAction();

    class Adder
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mult(int a, int b) => a * b;
        public int Div(int a, int b) => a / b;
        public int Mod(int a, int b) => a % b;

        public void Method1()
        {
            WriteLine("Hello Action delegates!!!!!!");
        }
        public void Method2()
        {
            WriteLine("Good Morning Action delegates!!!!!!");
        }


        public delegate void dgEventRaiser();
        // public delegate void Action();
        public event dgEventRaiser OnSumModFive;

        public int Add2(int a, int b)
        {
            int sum = a + b;
            if (sum % 5 == 0)
            {
                OnSumModFive();
            }

            return sum;
        }
    }
}


