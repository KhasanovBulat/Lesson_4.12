using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    class BankAccount
    {
        public ushort AccountNumber { get; }
        public decimal Balance { get; set; }
        public AccountType AccountType { get; }

        public string Holder { get; set; }

        public BankAccount()
        {

        }
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
            return $"Account number: {AccountNumber}\n Balance: {Balance}\n Account Type: {AccountType}\n Держатель счета: {Holder}";
        }
    }
}
