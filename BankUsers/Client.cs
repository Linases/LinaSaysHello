using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUsers
{
    public class Client : User
    {
        public bool IsVipOneClient { get; set; }
        

        public Client(string firstName, string lastName, int age, bool isVipClient=false) : base(firstName, lastName, age)
        {
            IsVipOneClient = isVipClient;
        }

        public void TakeLoan()
        {
            Console.WriteLine($"{LastName} {LastName} took loan:");
        }
    }
}

