using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._12
{
    class BankAccount
    {
        public ushort AccountNumber { get; }
        public decimal Balance { get;  }
        private AccountType AccountType { get; }

        public BankAccount(ushort AccountNumber, decimal Balance, AccountType AccountType)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.AccountType = AccountType;
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAccount)
            {
                BankAccount ba1 = obj as BankAccount;
                return ba1.Balance == Balance && ba1.AccountType == AccountType;
            }
            else
            {
                return false;
            }
        }

        

        public static bool operator ==(BankAccount ba1, BankAccount ba2)
        {
            if ((ba1.Balance == ba2.Balance) && (ba1.AccountType == ba2.AccountType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(BankAccount ba1, BankAccount ba2)
        {
            if ((ba1.Balance != ba2.Balance) && (ba1.AccountType != ba2.AccountType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return AccountNumber;
        }

        public override string ToString()
        {
            return $"Account number: {AccountNumber}\n Balance: {Balance}\n Account Type: {AccountType}";
        }

    }
}
