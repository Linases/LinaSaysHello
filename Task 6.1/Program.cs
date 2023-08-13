using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinaSaysHello
{
    internal class BankAccount
    {
        private static int _accountNumberCounter = 0;

        private readonly int _accountNumber;

        private decimal _accountBalance;

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public decimal AccountBalance
        {
            get { return _accountBalance; }
        }

        public BankAccount(decimal initialBalance)
        {
            _accountBalance = initialBalance;
            _accountNumberCounter++;
            _accountNumber = _accountNumberCounter;
        }

        public void Deposit(decimal depositAmount)
        {
            _accountBalance += depositAmount;
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (_accountBalance >= withdrawAmount)
            {
                _accountBalance -= withdrawAmount;
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account: {AccountNumber}");
            }
        }

        public string GetAccountInfo()
        {
            return $" {_accountBalance}, {_accountNumber}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAccount = new BankAccount(20);
            BankAccount secondAccount = new BankAccount(10);
            BankAccount thirdAccount = new BankAccount(10);

            firstAccount.Withdraw(5);
            secondAccount.Withdraw(50);
            thirdAccount.Deposit(20);

            Console.WriteLine("firstAccount: " + firstAccount.GetAccountInfo());
            Console.WriteLine("secondAccount: " + secondAccount.GetAccountInfo());
            Console.WriteLine("thirdAccount: " + thirdAccount.GetAccountInfo());

        }

    }
}







