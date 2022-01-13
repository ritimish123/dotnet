// Use the classes created in teh question 2 to implement the trasactions. 
// Create an array of accounts object
// Create the implementation of transaction between the accounts.
// Also implementa menu based interaction.
// The menu gives option for
// Print statement
// Transfer amount
// exit
// ***********************************************************************************************************



using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Account
    {
        int id;
        double balance;
        string name;
        public string type;

        public Account(int id, double balance, string name)
        {
            this.id = id;
            this.balance = balance;
            this.name = name;
        }

        public int Id { get { return id; } set { this.id = value; } }
        public double Balance { get { return balance; } set { this.balance = value; } }
        public string Name { get { return name; } set { this.name = value; } }
        public void transact()
        {
            Console.WriteLine(Name + " is transacting");

        }
        public void printBalance()
        {
            Console.WriteLine(Name + " Balance:" + this.balance);
        }

        public override string ToString()
        {
            return "Account details: " + Id + " " + Name + " " + Balance + " ";
        }
    }
    class Saving : Account
    {
     
        public Saving(int id, double balance, string name) : base(id, balance, name)
        {
            base.type = "saving";
        }

        public void ConvertToFd()
        {
            Console.WriteLine(Name + " has converted to Fd");
        }
    }
    class Current : Account
    {

        public Current(int id, double balance, string name) : base(id, balance, name)
        {
            base.type = "current";
        }
        public void Overdraw()
        {
            Console.WriteLine(Name + " has overdraw");
        }
    }
    class Transaction {
        public void transfer(Saving[] sav, Current[] cur) {
            Console.WriteLine("enter account number");
            int accountnumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter account type: saving/current");
            string type = Console.ReadLine();
            for(int i=0;i<sav.Length;i++)
            {
                if(sav[i].Id==accountnumber && sav[i].type.Equals("saving"))
                {
                    Console.WriteLine("Enter account number to transfer");
                    int transferaccount = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter account type to transfer saving/current");
                    string transferaccounttype = Console.ReadLine();
                    if (transferaccounttype.Equals("saving"))
                    {
                        for (int j = 0; j < sav.Length; j++)
                        {
                            if (sav[j].Id == transferaccount)
                            {
                                Console.WriteLine("Enter amount");
                                int a = Int32.Parse(Console.ReadLine());
                                sav[j].Balance += a;
                            }
                        }
                    }
                    else if (transferaccounttype.Equals("current"))
                    {
                        for (int j = 0; j < cur.Length; j++)
                        {
                            if (cur[j].Id == transferaccount)
                            {
                                Console.WriteLine("Enter amount");
                                int a = Int32.Parse(Console.ReadLine());
                                cur[j].Balance += a;
                            }
                        }
                    }
                      }
                else
                {
                    Console.Write("account not found");
                }
            }


        }
}
    class Inheritance3
    {
        public static void Main(string[] a)
        {
            Console.WriteLine("enter the number of saving accounts");
            int savecount = Int32.Parse(Console.ReadLine());
            Saving[] savings = new Saving[savecount];
            Console.WriteLine("Enter data: ");
            for (int i=0;i<savecount;i++)
            {
                Console.WriteLine("\t" +
                    "Account Number " + " Name " + " Balance"
                    );
                int id = Int32.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                double balance = double.Parse(Console.ReadLine());
                savings[i] = new Saving(id,balance,name);
            }


            Console.WriteLine("enter the number of current accounts");
            int curentcount = Int32.Parse(Console.ReadLine());
            Current[] currents = new Current[curentcount];

            Console.WriteLine("Enter data: "
                   );

            for (int i = 0; i < curentcount; i++)
            {
                Console.WriteLine("Enter Data:\n" +
                    "Account Number " + " Name " + " Balance"
                    );
                int id = Int32.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                double balance = double.Parse(Console.ReadLine());
                currents[i] = new Current(id, balance, name);
            }


            Console.WriteLine("Saving account details: \n");
            foreach(var i in savings)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("\nCurrent account details: \n");
            foreach (var i in currents)
            {
                Console.WriteLine(i + " ");
            }


            Transaction transaction = new Transaction();
            while (true)
            {
                Console.WriteLine("Enter the choice: 1:Display all  2:transfer 3:exit");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Saving account details: \n");
                    for (int i = 0; i < savings.Length; i++)
                    {
                        Console.WriteLine(savings[i]);

                    }

                    Console.WriteLine("Current account details: \n");
                    for (int i = 0; i < currents.Length; i++)
                    {
                        Console.WriteLine(currents[i]);

                    }
                }
                else if (choice == 2)
                {
                    
                    transaction.transfer(savings, currents);
                }
               
                else if (choice == 3)
                {
                    Console.WriteLine("Thank you");
                    break;
                }
                else
                {

                    Console.WriteLine("Enter correct input");
                }
            }
        }
    }
}
