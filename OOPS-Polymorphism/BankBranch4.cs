using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Polymorphism
{

    class BankBranch4
    {
        string name;
        string location;
        string manager;
        BankAccount4[] BankAccounts=new BankAccount4[10000];
        Customer4[] Customers=new Customer4[1000];

        public BankBranch4()
        {
            name = null;
            location = null;
            manager = null;
        }
        public BankBranch4(string name,string location,string manager):this()
        {
            this.name = name;
            this.location = location;
            this.manager = manager;
        }

        public string BName
        {
            set { name = value; }
            get { return name; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }
        public BankAccount4[] Bank
        {
            get { return BankAccounts; }
            set { BankAccounts = value; }
        }
        public Customer4[] Customer
        {
            get { return Customers; }
            set { Customers = value; }
        }
        public void AddCustomer(Customer4 newCustomer)
        {
            Customers[newCustomer.CID] = newCustomer;
        }

        public void AssignAccount(Customer4 newCustomer ,int i) //assigning cutor with a new bank account
        {

            if(i==1)
                BankAccounts[newCustomer.CID] = new BankAccount4(newCustomer);     ///SAVINGS ACCOUNT
            else if(i==2)
                BankAccounts[newCustomer.CID] = new CurrentAccount(newCustomer);    ///CURRENT ACCOUNT
            else if (i==3)
                BankAccounts[newCustomer.CID] = new OverDraftAccouunt(newCustomer);  ///OVERDRAFT ACCOUNT
        }
        public void AddOverseasAccount(Customer4 newCustomer,string Currency)
        {
            BankAccounts[newCustomer.CID] = new overseasAccount(newCustomer,Currency); //
        }
       
        public void addJointAccount(Customer4 newCustomer, Customer4 oldCustomer) //the new person and the object of the corresponsing account
        {
            BankAccounts[oldCustomer.CID].addJoint(newCustomer);
            //storing the new customer in to the account of old customer as joint account
        }

        public void PrintAllCustomer()
        {
            Console.WriteLine("Printing All Customers enrolled in Bank :----------------------------------------------");
            for (int i = 0; i < Customers.Length; i++)
            {
                if (Customers[i] != null)
                     Customer[i].Display();
            }
            Console.WriteLine("\t---------------------------------------------------------------------------------");
        }
        public void PrintAllAccountDetails()
        {
            Console.WriteLine("Printing All the Account Details :----------------------------------------------");

            for (int i = 0; i <BankAccounts.Length; i++)
            {
                if(this.BankAccounts[i] != null)
                {
                    this.BankAccounts[i].PrintAccountData();
                }
            }
            Console.WriteLine("\t---------------------------------------------------------------------------------");
        }

        public double GetBalance(Customer4 Customer)
        {
            double result = BankAccounts[Customer.CID].Balance;
            return result;
        }
        public void Withdraw(Customer4 Customer,double money)
        {
           if(! BankAccounts[Customer.CID].Withdraw(money))
                Console.WriteLine("\t\t\tInsufficient Funds ");
        }
        public void Deposite(Customer4 Customer, double money)
        {
            BankAccounts[Customer.CID].Deposite(money);
        }
        public void CreditInterest(Customer4 customer)
        {
            BankAccounts[customer.CID].CreditInterest();
        }
        public void TransferMoney(Customer4 First,Customer4 second,double money)
        {
           if(! BankAccounts[First.CID].Transfer(BankAccounts[second.CID],money))
                Console.WriteLine("Transfer Failed");
        }
        public void PrintCustomerData(Customer4 customer)
        {
            BankAccounts[customer.CID].PrintAccountData();
        }

    }
}
