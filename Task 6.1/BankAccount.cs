using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
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

    }

