using System;

namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {            
            BankAccount bankAccount_1 = new(10000, BankAccount.typesOfBankAccounts.checking_account);
           
            
            BankAccount bankAccount_2 = new(1000, BankAccount.typesOfBankAccounts.investment_account);
            

            BankAccount bankAccount_3 = new(1000, BankAccount.typesOfBankAccounts.investment_account);

            object obj = "hello";

            Console.WriteLine(bankAccount_1 == obj);

            Console.WriteLine(bankAccount_1 == bankAccount_2);

            Console.WriteLine(bankAccount_1 != bankAccount_2);

            Console.WriteLine(bankAccount_3 == bankAccount_2);

            Console.WriteLine(bankAccount_3 != bankAccount_2);

            Console.WriteLine(bankAccount_3.ToString());

            Console.WriteLine(bankAccount_1.GetHashCode());

            Console.WriteLine(bankAccount_2.GetHashCode());

            Console.WriteLine(bankAccount_3.GetHashCode());
        }
    }
}
