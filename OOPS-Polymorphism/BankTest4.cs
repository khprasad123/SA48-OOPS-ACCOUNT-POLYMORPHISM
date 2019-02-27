using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Polymorphism
{
    class BankTest4
    {    /// <summary>
    /// //              1.SAVINGS           2.CURRENT       3.OVERDRAFT
    /// </summary>
        static void Main()
        {
            BankBranch4 B1 = new BankBranch4("DBS", "Singapore", "Harirpasad");

            Customer4 C1 = new Customer4("hariprasad", "kottarathil", 23);

            B1.AddCustomer(C1);
            B1.AssignAccount(C1,1); //asigning account to the bank account pool

            Customer4 C2 = new Customer4("Kannan", "kottarathil", 25);
            Customer4 C3 = new Customer4("dsadas", "kottarathil", 54);
            Customer4 C4 = new Customer4("gfdgdf", "kottarathil", 90);
            Customer4 C5 = new Customer4("vcxv", "kottarathil", 78);
            Customer4 C6 = new Customer4("plplp", "kottarathil", 12);
         

            B1.AddCustomer(C2);
            B1.AddCustomer(C3);
            B1.AddCustomer(C4);
            B1.AddCustomer(C5);
            B1.AddCustomer(C6);
            /*
                FIRST WE WANT TO CREATE BANK BRANCH
                USING THAT BRANCH CREATE CLIENTS ACCORDINGLY
                SO BANK BRANCH IS ALWAYS THE PARENT OBJECT 
                   BANK-BRANCH.FUNCTION ----THIS SHOULD BE THE IMPLEMENTATION
                
                EACH CUSTOMER IS ASSIGNED TO SEPERATE ACCOUNTS
                REFER FUNTION DEFINISTION FOR BETTER UNDERSTANDING
            */
           
            B1.AssignAccount(C2,2);
            B1.AssignAccount(C3,3);
           


            B1.Deposite(C1, 1000);
            B1.Deposite(C2, 1000);
            B1.Deposite(C3, 1000);
            B1.CreditInterest(C1);
            B1.CreditInterest(C2);
            B1.CreditInterest(C3);

            B1.AddOverseasAccount(C4, "SGD");
            B1.AddOverseasAccount(C5, "USD");
            B1.Deposite(C4, 156);
            B1.Deposite(C5, 12210);


            B1.PrintAllCustomer();
            B1.PrintAllAccountDetails();

            B1.TransferMoney(C1, C2, 65);   ///TRANSFERING FROM C1 TO C2
          //  B1.PrintAllAccountDetails();
        }
    }
}
