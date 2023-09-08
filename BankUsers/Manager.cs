using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUsers
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public void Fire(Employee employee)
        {
            Console.WriteLine($" {employee.FirstName} {employee.LastName} has been fired");

        }

        public override void DoWork()
        {
            Console.WriteLine("Manager manages employees.");
        }
    }
}
