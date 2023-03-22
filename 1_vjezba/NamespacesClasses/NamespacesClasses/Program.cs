using NamespacesClasses.Classes;
using System;

namespace NamespacesClasses
{
    interface IOperations
    {
        float Remainder(float dividend, float divisor);
    }

    class SimpleMath
    {
        public static void Add(int x, int y)
        {
            var rez = x + y;
            Console.WriteLine(rez);
        }
        public static void Subtract(int x, int y)
        {
            var rez = x - y;
            Console.WriteLine(rez);
        }
        public static void Mult(int x, int y)
        {
            var rez = x * y;
            Console.WriteLine(rez);
        }
        public static void Divide(int x, int y)
        {
            var rez = x / y;
            Console.WriteLine(rez);
        }

        

    }
    
    class AdvancedMath : SimpleMath, IOperations
    {
        public float Remainder(float dividend, float divisor)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static async void GetData()
        {
            BankAccount account = new BankAccount("Ivo Ivić", 3000f);
            Console.WriteLine("Log in");
            var task = await account.GetData();
            Console.WriteLine(task);
        }
        static void Main(string[] args)
        {
            BankAccount owner1 = new BankAccount("Jane Doe", 100);
            BankAccount owner2 = new ChildBankAccount("Tim Doe", 10, "Jane Doe");
            Console.WriteLine($"Owner1: {owner1.Owner}");
            Console.WriteLine($"Owner1's balance is: {owner1.Balance}");
            owner1.AddBalance(-5000, true);
            Console.WriteLine($"Owner1's balance is now:{ owner1.Balance}");
            GetData();

        }
    }
}