using System;
using System.Text;

namespace VS_demo
{
    enum Importance
    {
        None,
        Trivial,
        Regular,
        Important,
        Critical
    }

    public delegate int Operation(int a, int b);
    public delegate void PrintMsg();

    class Program
    {
        static void Main(string[] args)
        {
            Importance value = Importance.Critical;

            if (value == Importance.Critical)
                Console.WriteLine("Very important");

            // Generic
            bool b1 = isEqual("9", "9");
            bool b2 = isEqual(10.9, 10.9);

            Console.WriteLine(b1 ? "equal" : "not equal");
            Console.WriteLine(b2 ? "equal" : "not equal");

            // String builder
            string path = "C:";

            path = path + "\\Csharp";
            path = path + "\\Lessons";
            path += "\\Lessons-001.cs";

            Console.WriteLine(path);

            StringBuilder sb = new StringBuilder("C:");

            sb.Append("\\Csharp").Append("\\Lessons").Append("\\Lessons-001.cs");

            Console.WriteLine(sb);

            StringBuilder sb2 = new StringBuilder("This is an example string that is an example");
            // an to the
            sb2.Replace("an", "the");

            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder();

            sb3.AppendFormat("Hello {0}. This is {1}", "Mike", "Friday", "Monday");
            sb3.AppendLine();
            sb3.AppendLine();
            sb3.AppendLine();
            sb3.AppendLine();
            sb3.Append("New Line");
            Console.WriteLine(sb3[0]);

            // join(', ') // one, two, three
            string[] elems = { "bird", "cat", "dog" };
            StringBuilder sb4 = new StringBuilder();

            sb4.AppendJoin(", ", elems); // *

            Console.WriteLine(sb4);

            // delegates

            int res = 0;

            res = Run(new Operation(Add), 22, 44);

            Console.WriteLine("res = {0}", res);


            Talk(new PrintMsg(Hello));
            Talk(new PrintMsg(Bye));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Talk(PrintMsg pm)
        {
            pm.Invoke(); // pm()
        }

        static void Hello()
        {
            Console.WriteLine("Hello!");
        }

        static void Bye()
        {
            Console.WriteLine("Bye!");
        }

        static int Subt(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static int Run(Operation act, int a, int b)
        {
            return act(a, b);
        }

        static bool isEqual<T>(T a, T b)
        {
            return a.Equals(b); // ==
        }

        static bool isEqual2(object a, object b)
        {
            return a.Equals(b); // ==
        }
    }
}


