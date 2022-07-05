using System;

namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account_1 = new(10_000, BankAccount.typesOfBankAccounts.checking_account);
            account_1.Print();

            BankAccount account_2 = new(15_000, BankAccount.typesOfBankAccounts.checking_account);
            account_2.Print();

            account_1.TransferMoney(account_2, 2000);
            account_1.Print();
            account_2.Print();
        }
    }
}
