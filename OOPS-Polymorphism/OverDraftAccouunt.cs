using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Polymorphism
{
    class OverDraftAccouunt : BankAccount4
    {
        public OverDraftAccouunt(Customer4 NewCustomer) : base(NewCustomer) { }
        public override void CreditInterest()
        {
            Balance += Balance * 0.05; /// 5% for overDraftAccount
            Console.WriteLine("\t\t\tInterst 5% Credited $" + (Balance * 0.05) + "\n\t\t\tFinal Balance : " + Balance);
        }
    }
    class CurrentAccount : BankAccount4
    {
        public CurrentAccount(Customer4 NewCustomer) : base(NewCustomer) { }
        public override void CreditInterest()
        {
            Balance += Balance * 0.01; /// 1% for Current Account
            Console.WriteLine("\t\t\tInterst 1% Credited $" + (Balance * 0.01) + "\n\t\t\tFinal Balance : " + Balance);
        }
    }
    class overseasAccount : BankAccount4
    {
        string Currency;
        public string CURRENCY
        {
            get { return Currency; }
            set
            {
                Currency = value;
            }
        }
        public overseasAccount(Customer4 NewCustomer,string Currency) : base(NewCustomer) { CURRENCY = Currency; }
        public override void PrintAccountData()
        {
            Console.WriteLine("\n\n\tID No : ".PadRight(20, ' ') + Cus.CID);
            //   Console.WriteLine("\n\n\tID No : ".PadRight(20, ' ') + Joint.CID);
            Console.WriteLine("\tAccount No : ".PadRight(20, ' ') + Acc_No);
            Console.WriteLine("\tOwner : ".PadRight(20, ' ') + Cus.Name);
            Console.WriteLine("\tAddress : ".PadRight(20, ' ') + Cus.Address);
            Console.WriteLine("\tAge : ".PadRight(20, ' ') + Cus.Age);
            Console.WriteLine("\tBalance : ".PadRight(20, ' ') + CURRENCY +" "+ Balance);
            Console.WriteLine("\tAccount state now is ".PadRight(20, ' ') +State + "\n\n");

            if (Joint != null)
            {
                Console.WriteLine("\nYour Joint Holder");
                Console.WriteLine("\n\n\tID No : ".PadRight(20, ' ') + Joint.CID);
                Console.WriteLine("\tJoint Owner : ".PadRight(20, ' ') + Joint.Name);
                Console.WriteLine("\tAddress : ".PadRight(20, ' ') + Joint.Address);
                Console.WriteLine("\tAge : ".PadRight(20, ' ') + Joint.Age);
            }

        }

    }
}
