using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    

    public class BankAccount
    {
        public enum typesOfBankAccounts
        {
            checking_account,
            savings_account,
            investment_account
        }

        private static int _numberOfTheAccount = 1000;
        private int _deposit;
        private typesOfBankAccounts _account_type;

        public int NumberOfTheAccount
        {
            get { return _numberOfTheAccount; }
        }

        public int Deposit
        {
            get { return _deposit; }
            set
            {
                if (value > 0 && value < 1_000_000)
                {
                    _deposit = value;
                }
            }
        }

        public void PutMoney(int money)
        {
            if (money > 1_000_000)
            {
                Console.WriteLine("Предъявите декларацию о доходах!\n");
                return;
            }
            if (money < 0)
            {
                Console.WriteLine("Перепутали операцию снятия денег!\n");
                return;
            }
            else
            {
                Deposit += money;
                Console.WriteLine($"Операция успешно выполнена, ваш баланс {Deposit}$\n");
            }
        }

        public void WithdrawMoney(int money)
        {
            if (money > Deposit)
            {
                Console.WriteLine($"Вам не хватает на счету {money - Deposit}$\n");
            }
            else
            {
                Deposit -= money;
                Console.WriteLine($"Операция успешно выполнена, ваш баланс {Deposit}$\n");
            }
        }

        public typesOfBankAccounts Type
        {
            get { return _account_type; }
            set
            {
                _account_type = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BankAccount))
                return false;
            BankAccount b = (BankAccount)obj;
            if (this.NumberOfTheAccount == b.NumberOfTheAccount
                && this.Deposit == b.Deposit)
                return true;
            else
                return false;
        }

        public static bool operator ==(BankAccount a, BankAccount b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(NumberOfTheAccount, Deposit, Type).GetHashCode();
        }

        public override string ToString()
        {
            return $"Номер банковского счета: {NumberOfTheAccount}\nДепозит: {Deposit}\nТип банковского счета: {Type}\n";
        }

        public BankAccount() : this(5000) { }
        public BankAccount(int deposit) : this(deposit, typesOfBankAccounts.checking_account) { }
        public BankAccount(int deposit, typesOfBankAccounts type)
        {
            _numberOfTheAccount++;
            Deposit = deposit;
            _account_type = type;
        }
    }
}
