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
        private static int numberOfTheAccount = 1000;
        private int deposit;
        private typesOfBankAccounts account_type;

        public int NumberOfTheAccount
        {
            get {return numberOfTheAccount;}
        }

        public int Deposit
        {            
            get{return deposit;}
            set
            {
                if(value>0 && value<1_000_000)
                {
                    deposit = value;
                }
            }
        }

        public typesOfBankAccounts Type
        {
            get { return account_type; }
            set
            {
                account_type = value;
            }
        }

        
        public BankAccount() : this( 5000) { }
        public BankAccount(int deposit) : this(deposit, typesOfBankAccounts.checking_account) { }
        public BankAccount(int deposit, typesOfBankAccounts type)
        {
            numberOfTheAccount++;
            this.Deposit = deposit;
            this.account_type = type;
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
            BankAccount bankAccount_1 = new(10000, typesOfBankAccounts.checking_account);
            bankAccount_1.Print();
            
            BankAccount bankAccount_2 = new(1000, typesOfBankAccounts.investment_account);
            bankAccount_2.Print();

            BankAccount bankAccount_3 = new(1000, typesOfBankAccounts.savings_account);
            bankAccount_3.Print();
        }
    }
}
