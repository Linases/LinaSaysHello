using BankUsers;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client("Name", "Surname", 22);
        Console.WriteLine($" Client name: {client.FirstName}, client Last Name: {client.LastName}, Client age: {client.Age}, VIP status: {client.IsVipOneClient}");
        client.TakeLoan();

        Employee employee = new Manager("EmployeetName", "EmployeeLastname", 22);
        //employee = new LoanSpecialist("EmployeetName", "EmployeeLastname", 22);

        Console.WriteLine(employee.IsEmployeeofTheMonth());

        Employee.EmployeeOfTheMonth = employee;
        
        Console.WriteLine(employee.IsEmployeeofTheMonth());
        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Age}");
        //employee.Quit();

        Manager manager = new Manager("ManagerName", "ManagerLastname", 22);
        //manager.Fire(employee);
        
        if (employee is Manager)
        {
            ((Manager)employee).Fire(employee);
        }

        employee.DoWork();
        manager.DoWork();
    }


}