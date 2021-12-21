using System;

namespace Bank.Core
{
    public class BankAccount
    {
        private readonly Guid _id;
        private readonly BankAccountType _type;
        private decimal _balance;

        public BankAccount(BankAccountType type)
        {
            _id = Guid.NewGuid();
            _type = type;
        }

        public Guid Id => _id;
        public BankAccountType Type => _type;
        public decimal Balance => _balance;

        public void Deposit(decimal sum)
        {
            _balance += sum;
        }

        public bool TryWithdraw(decimal sum)
        {
            if (_balance - sum < 0) return false;
            _balance -= sum;
            return true;
        }
    }
}
