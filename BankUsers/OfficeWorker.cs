using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUsers
{
    public class OfficeWorker : Employee
    {
        public OfficeWorkerTypes.OfficeWorker OfficeWorkerType { get; set; }
        public OfficeWorker (string firstName, string lastName, int age, OfficeWorkerTypes.OfficeWorker officeWorkerType) : base(firstName, lastName, age)
        {
            OfficeWorkerType = officeWorkerType;
        }

    }
}
