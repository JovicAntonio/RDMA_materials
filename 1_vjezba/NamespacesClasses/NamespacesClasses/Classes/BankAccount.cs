using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NamespacesClasses.Classes
{
    internal class BankAccount
    {
        private float balance;
        private string owner;


        public BankAccount(string owner, float balance)
        {
            Owner = owner;
            Balance = balance;

        }

        public virtual float AddBalance(float balanceToBeAdded, bool canBeNegative)
        {
            if(canBeNegative) balance = balance + balanceToBeAdded;
            else Balance = Balance + balanceToBeAdded;
            return Balance;
        }

        public float Balance { 
            get { return balance; }
            private set { if (value >= 0) balance = value; else balance = 0; }
        }
        public string Owner { get; set; }

        public async Task<string> GetData()
        {
            Console.WriteLine("Logging in...\n");
            Thread.Sleep(2000);
            return "Completed";
        }

    }
        
    class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }
        public ChildBankAccount(string owner, float balance, string parent) :
        base(owner, balance)
        {
            Parent = parent;
        }
        public override float AddBalance(float balanceToBeAdded, bool canBeNegative = false)
        {
            return base.AddBalance(balanceToBeAdded, canBeNegative);
        }
    }
    



}
