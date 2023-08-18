using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUsers
{
    public class Employee : User
    {
        public static Employee EmployeeOfTheMonth { get; set; }

        public Employee(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public void Quit()
        {
            Console.WriteLine($"{LastName} {LastName} quit.");
        }
        public bool IsEmployeeofTheMonth()
        {
            return this == EmployeeOfTheMonth;
        }

        public virtual void DoWork()
        {
            Console.WriteLine("Employee works");
        }
    }
}
