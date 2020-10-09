using System;
using System.Data;

namespace VS_demo
{
    public class Program
    {
        private static int balance;
        private static string customer;
        
        static void Main(string[] args)
        {
            customer = "Mark";
            balance = 0;
        }

        public static void SetBalance(int amount)
        {
            balance = amount;
        }

        public static void Debit(int amount)
        {
            if (balance == 0)
                throw new Exception("balance == 0");

            if (amount <= 0)
                throw new ArgumentOutOfRangeException("amount <= 0");

            if (amount > balance)
                throw new Exception("Insufficient fund");

            balance -= amount;
        }

        public static int Devide(int num, int denom)
        {
            return num / denom;
        }

    }
}


