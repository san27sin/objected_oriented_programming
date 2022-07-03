using System;

namespace objected_oriented_programming
{
    enum typesOfBankAccounts
    {
        checking_account,
        savings_account,
        investment_account
    }

    class BankAccount
    {
        private int numberOfTheAccount;
        private int deposit;
        private typesOfBankAccounts account_type;

        public int NumberOfTheAccount
        {
            set
            {
                if (value > 1000)
                {
                    numberOfTheAccount = value;
                }
                else
                    numberOfTheAccount = 1000;

            }
            get
            {
                return numberOfTheAccount;
            }
        }

        public int Deposit
        {
            set
            {
                if (value < 0)
                {
                    deposit = 0;
                }
                else
                    deposit = value;
            }

            get
            {
                return deposit;
            }
        }

        public typesOfBankAccounts Type
        {
            get
            {
                if (account_type == 0)
                    return 0;
                else
                    return account_type;
            }
            set
            {
                account_type = value;
            }
        }

        public BankAccount() : this(1001) { }
        public BankAccount(int NumberOfTheAccount) : this(NumberOfTheAccount, 5000) { }
        public BankAccount(int NumberOfTheAccount, int deposit) : this(NumberOfTheAccount, deposit, typesOfBankAccounts.checking_account) { }
        public BankAccount(int NumberOfTheAccount, int deposit, typesOfBankAccounts type)
        {
            this.NumberOfTheAccount = NumberOfTheAccount;
            this.Deposit = deposit;
            this.Type = type;
        }


        //посмотреть что будет при вызове объекта без инициализации класса
        public void Print()
        {
            Console.WriteLine($"Номер банковского счета: {numberOfTheAccount}\nДепозит: {deposit}\nТип банковского счета: {account_type}\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount_1 = new();
            bankAccount_1.Print();

            BankAccount bankAccount_2 = new();
            bankAccount_2.Deposit = 1100;
            bankAccount_2.NumberOfTheAccount = 1002;
            bankAccount_2.Type = typesOfBankAccounts.investment_account;

            bankAccount_2.Print();
        }
    }
}
