using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VS_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                // ctrl + K + X
                //int i = 0;
                //int res = 10 / i;
                int i = 100;

                var anw1 = Console.ReadLine();



                if (i < 200)
                {
                    throw new FormatException("Input str is....");
                    throw new ArgumentOutOfRangeException("Value less then 200");
                }

                StreamReader sr = new StreamReader("d:\\test\\data.txt");

                Console.WriteLine(sr.ReadToEnd());

                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Yahhhh!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }


            Console.WriteLine("There is a big block code!!!!");
            */


            List<string> list = new List<string>(2);

            list.Add("001");
            list.Add("002");
            list.Add("003"); // i = 2, 002.5
            list.Add("004");
            list.Add("005");
            list.Add("006");
            list.Add("007");
            list.Add("008");
            list.Add("009");

            Console.WriteLine( list.Count + " " + list.Capacity );
            list[4] = "0044";
            Console.WriteLine(list[4]);

            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------");

            list.Insert(2, "002.5");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(list.IndexOf("00800")); // -1

            Console.WriteLine(list.Contains("007")); // -1

            // Predicate 

            Console.WriteLine(list.Exists(s => s == "0077"));
            Console.WriteLine("-----------------------------------------");

            List<string> names = new List<string>();

            names.Add("Bob");
            names.Add("Mark");
            names.Add("Steve");
            names.Add("Mike");


            List<string> names2 = new List<string>();

            names2.Add("Lana");
            names2.Add("Mary");
            names2.Add("Tom");

            names.InsertRange(3, names2);

            Console.WriteLine(names.Find(n => n.StartsWith('M')));
            Console.WriteLine(names.FindLast(n => n.StartsWith('M')));

            var filteredNames = names.FindAll(n => n.StartsWith('M'));

            // names.Remove("Tom");
            names.RemoveAll(n => n.StartsWith('M'));


            Console.WriteLine("-----------------------------------------");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");

            string[] namesArr = names.ToArray();

            for (int i = 0; i < namesArr.Length; i++)
            {
                Console.WriteLine(namesArr[i]);
            }
            Console.WriteLine("-----------------------------------------");

            List<string> l_copy = namesArr.ToList();

            foreach (var item in l_copy)
            {
                Console.WriteLine(item);
            }
        }

    }
}


