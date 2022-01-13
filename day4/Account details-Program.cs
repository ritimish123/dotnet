
// Create a class account
// inherit the current and the savings account from it
// Account class has number,name and balance(properties)
// transact,print balance(behaviour)
// Saving has convertToFD method
// Current has OverDraw method
 
// Create objects of current and savings account to see the members(properties and behaviour) 


// *******************************************************************************************************************



using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {
        int id;
        double balance;
        string name;

        public Account(int id, double balance, string name)
        {
            this.id = id;
            this.balance = balance;
            this.name = name;
        }

        public int Id{get{return id;} set{this.id=value;} }
        public double Balance  { get { return balance; } set { this.balance = value; } }
        public string Name { get { return name; } set { this.name = value; } }
        public void transact()
        {
            Console.WriteLine(Name+" is transacting");

        }
        public void printBalance()
        {
            Console.WriteLine(Name+" Balance:"+this.balance);
        }

        public override string ToString()
        {
            return "Account details: " + Id + " " + Name + " " + Balance + " ";
        }
    }
    class Saving:Account {
        public Saving(int id, double balance, string name) : base(id, balance, name)
        {

        }

        public void ConvertToFd()
        {
            Console.WriteLine(Name+" has converted to Fd");
        }
    }
    class Current :Account{
        public Current(int id, double balance, string name) : base(id, balance, name)
        {

        }
        public void Overdraw()
        {
            Console.WriteLine(Name+" has overdraw");
        }
    }
   public  class Inheritance2
    {
        public static void Main(string[] a)
        {
            Saving saving = new Saving(123,30000,"Vaishali");
            Current current = new Current(124, 30000, "ttt");
            Console.WriteLine(saving);
            saving.transact();
            saving.printBalance();
            saving.ConvertToFd();

            Console.WriteLine(current);
            current.transact();
            current.printBalance();
            current.Overdraw();

        }
    }
}
