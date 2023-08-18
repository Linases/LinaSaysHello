using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUsers
{
    public class LoanSpecialist : OfficeWorker
    {
        public LoanSpecialist(string firstName, string lastName, int age) : base(firstName, lastName, age)
        { 
        }

        public override void DoWork()
        {
            Console.WriteLine("Lone Specialist gives loan.");
        }
    }
}
