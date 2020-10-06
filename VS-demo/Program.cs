using System;

namespace VS_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // \n \t
            string str = "One\two\nThree";
            Console.WriteLine(str);

            str = "c:/Robertson\\CSharp\\Lessons\\Lesson-001.cs";
            Console.WriteLine(str);

            str = @"c:\Robertson\CSharp\Lessons\Lesson-001.cs";
            Console.WriteLine(str);
             */

            // Arrays
            // int[] evenNumbers = { 2, 3, 4, 5, 6 };
            int[] evenNumbers = new int[10]; // 0, 2, 4, 6, 8 ... length 10

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                evenNumbers[i] = i * 2;
            }

            foreach (int e in evenNumbers)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            // Method parameters

            var param = 11;
            simpleMethod(ref param);

            Console.WriteLine(param);
            param = simpleMethod2(777);
            Console.WriteLine( param );

            int sum = 0, prod = 0;
            sNp(3, 4, out sum, out prod);

            Console.WriteLine($"{sum}  {prod}");


        }

        static void sNp(int a, int b, out int sum, out int prod)
        {
            sum = a + b;
            prod = a * b;
        }

        static void simpleMethod(ref int param)
        {
            param = 77;
        }

        static int simpleMethod2(int param)
        {
            param = 77;
            return param;
        }
    }
}
